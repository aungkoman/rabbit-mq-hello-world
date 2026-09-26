const express = require('express');
const amqp = require('amqplib');

const app = express();
const PORT = 3003;
const EXCHANGE_NAME = 'person_events';

async function connectRabbitMQ() {
    let connection;
    while (!connection) {
        try {
            connection = await amqp.connect('amqp://rabbitmq');
            const channel = await connection.createChannel();
            await channel.assertExchange(EXCHANGE_NAME, 'fanout', { durable: false });
            
            const q = await channel.assertQueue('', { exclusive: true });
            console.log("Service 3 (Express): Connected to RabbitMQ. Waiting for messages...");
            
            await channel.bindQueue(q.queue, EXCHANGE_NAME, '');
            
            channel.consume(q.queue, (msg) => {
                if (msg.content) {
                    const data = JSON.parse(msg.content.toString());
                    console.log(`[Service 3 - Relationship Setup] Received:`, data);
                }
            }, { noAck: true });
            
        } catch (error) {
            console.log("Service 3: Waiting for RabbitMQ...");
            await new Promise(resolve => setTimeout(resolve, 2000));
        }
    }
}

connectRabbitMQ();

app.get('/', (req, res) => res.send('Service 3 is running!'));

app.listen(PORT, () => {
    console.log(`Service 3 running on port ${PORT}`);
});