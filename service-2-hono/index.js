const { serve } = require('@hono/node-server');
const { Hono } = require('hono');
const amqp = require('amqplib');

const app = new Hono();
const EXCHANGE_NAME = 'person_events';
const EMAIL_QUEUE = 'email_service_queue';


async function connectRabbitMQ() {
    let connection;
    while (!connection) {
        try {
            connection = await amqp.connect('amqp://rabbitmq');
            const channel = await connection.createChannel();
            await channel.assertExchange(EXCHANGE_NAME, 'fanout', { durable: false });
            
            // Random Queue တစ်ခု ဖန်တီးပြီး Exchange နဲ့ ချိတ်ဆက်ပါမယ်
            const q = await channel.assertQueue('', { exclusive: true });
            console.log("Service 2 (Hono): Connected to RabbitMQ. Waiting for messages...");
            
            // Exchange က exchange, ဒါက ကော်ပီယူမယ့် Queue , ဒါမျိုး။ third parameter က routing key , လက်ရှိက အကုန်ယူမယ့် သဘော။
            await channel.bindQueue(q.queue, EXCHANGE_NAME, '');

            // အခုက email queue ကို consume လုပ်မယ်။
            await channel.assertQueue(EMAIL_QUEUE, { durable: false });
            // တစ်ခါကို တစ်လုပ်ပဲ လုပ်မယ်။ 
            channel.prefetch(1);

            console.log("Service 2 (Email Worker): Waiting for jobs...");

            channel.consume(EMAIL_QUEUE, (msg) => {
                if (msg) {
                    const data = JSON.parse(msg.content.toString());
                    const corrId = msg.properties.correlationId;
                    const replyTo = msg.properties.replyTo;
                    
                    console.log(`[Worker] Processing email to: ${data.email}, JobID: ${corrId}`);
                    
                    // ပုံမှန် Email ပို့တဲ့ ကြာချိန်တစ်ခုကို Simulate လုပ်မယ် (1.5 စက္ကန့်လောက် စောင့်မယ်)
                    setTimeout(() => {
                        // 50% Success, 50% Fail ဖြစ်အောင် Random ထုတ်မယ်
                        const isSuccess = Math.random() > 0.5;
                        
                        const responsePayload = {
                            target: data.email,
                            status: isSuccess ? 'DELIVERED' : 'FAILED',
                            reason: isSuccess ? 'Sent successfully to Mail server' : 'Mailbox unavailable or bounced',
                            timestamp: new Date()
                        };
                        
                        // Service 1 က တောင်းဆိုထားတဲ့ replyTo Queue ဆီကို ရလဒ် ပြန်ပို့မယ်
                        // ဒီကောင်က assert တွေ ဘာတွေ မလုပ်ပဲ ဘာလို့ တန်းပို့လို့ ရနေတာလဲ?
                        channel.sendToQueue(replyTo, Buffer.from(JSON.stringify(responsePayload)), {
                            correlationId: corrId // မူလ JobID ကို ပြန်ထည့်ပေးရမယ်
                        });
                        
                        console.log(`[Worker] Replied JobID: ${corrId} - Status: ${responsePayload.status}`);
                        
                        // Queue ထဲကနေ ဒီ Message ကို အပြီးသတ် ဖျက်ထုတ်လိုက်ပြီ (Acknowledge လုပ်တာပါ)
                        // ဘယ်ကို ပြန်ပို့မယ်တွေ ဘာတွေတောင် မပါဘူး။ event က ရလာတဲ့ payload / entity ကို ဒီအတိုင်း ပြန်ပို့လိုက်ရုံပဲ။ ကြမ်းတယ်ဗျ။
                        channel.ack(msg);
                    }, 5000);
                }
            });

            
            // Message ဝင်လာရင် အလုပ်လုပ်မယ့် အပိုင်း
            // ဒါက random queue , exchange နဲ့ bind ထားတဲ့ဟာ၊ duplicate 
            channel.consume(q.queue, (msg) => {
                if (msg.content) {
                    const data = JSON.parse(msg.content.toString());
                    console.log(`[Service 2 - Personal Info] Received:`, data);
                }
            }, { noAck: true });
            
        } catch (error) {
            console.log("Service 2: Waiting for RabbitMQ...");
            await new Promise(resolve => setTimeout(resolve, 2000));
        }
    }
}

connectRabbitMQ();

app.get('/', (c) => c.text('Service 2 (Hono) is running and listening to RabbitMQ!'));

serve({
  fetch: app.fetch,
  port: 3002
}, (info) => {
  console.log(`Service 2 running on port ${info.port}`);
});