const express = require('express');
const amqp = require('amqplib');

const app = express();
const PORT = 3001;
const EXCHANGE_NAME = 'person_events';

let channel;

// RabbitMQ နဲ့ ချိတ်ဆက်မယ့် Function
async function connectRabbitMQ() {
    let connection;
    while (!connection) {
        try {
            // Docker ထဲမှာ run မှာမို့ localhost အစား container name 'rabbitmq' ကို သုံးရပါတယ်
            connection = await amqp.connect('amqp://rabbitmq');
            channel = await connection.createChannel();
            // Fanout exchange ဆိုတာ message ပို့လိုက်ရင် ချိတ်ထားတဲ့ consumer တွေအကုန်လုံးဆီ ရောက်သွားမှာပါ
            await channel.assertExchange(EXCHANGE_NAME, 'fanout', { durable: false });
            console.log("Service 1: Connected to RabbitMQ");
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
        // Exchange ဆီကို Message လှမ်းပို့ပါတယ်
        channel.publish(EXCHANGE_NAME, '', Buffer.from(message));
        console.log(`[x] Sent: ${message}`);
        res.send(`Person '${personName}' event published to RabbitMQ!`);
    } else {
        res.status(500).send("RabbitMQ not connected yet.");
    }
});
app.get('/', (req, res) => { 
    res.send(`Service 1 (Publisher) is up and running name is {req.params.name} , welcome`);
     
});

app.listen(PORT, () => {
    console.log(`Service 1 (Publisher) running on port ${PORT}`);
});