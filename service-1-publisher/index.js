const express = require('express');
const amqp = require('amqplib');
const crypto = require('crypto'); // Job ID ဖန်တီးရန်

const app = express();
const PORT = 3001;

// Event နာမည်တွေ။
const EXCHANGE_NAME = 'person_events';
const EMAIL_QUEUE = 'email_service_queue';

let channel;
let replyQueue;

// database မရှိသေးလို့၊ Email Job တွေရဲ့ Status ကို မှတ်ထားမယ့် ယာယီ Memory Database
const jobDatabase = new Map();
// RabbitMQ နဲ့ ချိတ်ဆက်မယ့် Function
async function connectRabbitMQ() {
    let connection;
    while (!connection) {
        try {
            // Docker ထဲမှာ run မှာမို့ localhost အစား container name 'rabbitmq' ကို သုံးရပါတယ်
            // connect လုပ်မယ်။
            connection = await amqp.connect('amqp://rabbitmq');
            // channel create လုပ်မယ်။
            channel = await connection.createChannel();

            // ဒီ channel မှာ ဒီ event ရှိလား? assert လုပ်မယ်။ မရှိရင် create လုပ်မယ်။
            // Fanout exchange ဆိုတာ message ပို့လိုက်ရင် ချိတ်ထားတဲ့ consumer တွေအကုန်လုံးဆီ ရောက်သွားမှာပါ
            await channel.assertExchange(EXCHANGE_NAME, 'fanout', { durable: false });

            // Email ပို့မယ့် Queue
            await channel.assertQueue(EMAIL_QUEUE, { durable: false });

            // Email tracking
            // data type တွေ မသိတာက ခက်သားဗျ။ assertQueue ကနေ ဘာပြန်လာမလဲ? မသိနိုင်။
            const q = await channel.assertQueue('', { exclusive: true });
            replyQueue = q.queue;
            
            console.log("Service 1: Connected to RabbitMQ");

            channel.consume(replyQueue, (msg) => {
                if (msg) {
                    const corrId = msg.properties.correlationId;
                    const result = JSON.parse(msg.content.toString());
                    // ကိုယ့် အလုပ်လား စစ်မယ်။
                    if (jobDatabase.has(corrId)) {
                        // Job Status ကို Update လုပ်မယ်။
                        jobDatabase.set(corrId, { 
                            status: 'COMPLETED', 
                            details: result 
                        });
                        console.log(`[Job Updated] JobID: ${corrId} - Status: ${result.status}`);
                    }
                    // ကိုယ့် အလုပ်ကို ဟုတ်မနေတာ။ don't care, ok.
                }
            }, { noAck: true });


        } catch (error) {
            console.log("Service 1: Waiting for RabbitMQ...");
            await new Promise(resolve => setTimeout(resolve, 2000));
        }
    }
}

connectRabbitMQ();

// User အသစ် ထည့်မယ့် API Endpoint
app.get('/add-person/:name', (req, res) => {
    const personName = req.params.name;
    const message = JSON.stringify({ action: 'CREATE_PERSON', name: personName, timestamp: new Date() });
    
    if (channel) {
        channel.publish(EXCHANGE_NAME, '', Buffer.from(message));
        console.log(`[x] Broadcasted: ${message}`);
        res.send(`Person '${personName}' event published to Exchange!`);
    } else {
        res.status(500).send("RabbitMQ not connected yet.");
    }
});

app.get('/send-email/:email', (req, res) => {
    const targetEmail = req.params.email || 'nobody@example.com';
    const jobId = crypto.randomUUID();

    // ဒီမှာ အလွယ်တကူ မသိနိုင်တဲ့ နောက်ထပ် Data Structure တစ်ခု။ database နဲ့ ချိတ်တဲ့အခါတော့ ORM ဘာညာ နဲ့ type  strict ဖြစ်ပြီး အတိအကျ ရလာပါလိမ့်မယ်။
    // Status ကို PENDING ဆိုပြီး အရင်မှတ်ထားမယ်
    jobDatabase.set(jobId, { status: 'PENDING', details: null });

    const message = JSON.stringify({ email: targetEmail, subject: "Hello Multi-Pattern RabbitMQ" });

    if (channel && replyQueue) {
        // ဒါကျတော့ publish မလုပ်ပဲ။ sendToQueue တဲ့။ 
        // RabbitMQ အတွက် correlationId နဲ့ replyTo က သတ်မှတ်ပေးဖို့ လိုပြီ။
        channel.sendToQueue(EMAIL_QUEUE, Buffer.from(message), {
            correlationId: jobId,
            replyTo: replyQueue
        });
        
        console.log(`[x] Sent Email Task for ${targetEmail}. JobID: ${jobId}`);
        
        res.json({
            message: "Email request accepted and is processing in background.",
            jobId: jobId,
            trackUrl: `http://localhost:3001/track/${jobId}`
        });
    } else {
        res.status(500).send("RabbitMQ not connected.");
    }


});

app.get('/track/:jobId', (req, res) => {
    const jobId = req.params.jobId;
    const jobStatus = jobDatabase.get(jobId);
    
    if (jobStatus) {
        res.json({ jobId: jobId, data: jobStatus });
    } else {
        res.status(404).json({ error: "Job ID not found" });
    }
});

app.get('/', (req, res) => { 
    res.send(`Service 1 (Publisher) is up and running name is ${req.query.name || "You Know WHO"} , welcome`);
});

app.listen(PORT, () => {
    console.log(`Service 1 (Publisher) running on port ${PORT}`);
});