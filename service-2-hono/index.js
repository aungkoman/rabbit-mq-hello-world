const { serve } = require('@hono/node-server');
const { Hono } = require('hono');
const amqp = require('amqplib');

const app = new Hono();
const EXCHANGE_NAME = 'person_events';

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
            
            await channel.bindQueue(q.queue, EXCHANGE_NAME, '');
            
            // Message ဝင်လာရင် အလုပ်လုပ်မယ့် အပိုင်း
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