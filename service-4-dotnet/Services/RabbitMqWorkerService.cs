using System.Text;
using System.Text.Json; // Make sure to add this for JSON serialization
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace service_4_dotnet.Services;

public class RabbitMqWorkerService : BackgroundService
{
    private IConnection? _connection;
    private IModel? _channel;
    private readonly string _queueName = "email_service_queue"; // တိကျသော Queue အမည်

    public RabbitMqWorkerService()
    {
        InitRabbitMQ();
    }

    private void InitRabbitMQ()
    {
        var factory = new ConnectionFactory { HostName = "rabbitmq-server" };
        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        // Queue တည်ဆောက်ခြင်း (durable: true ထားခြင်းဖြင့် Server restart ကျလည်း Queue မပျောက်ပါ)
        _channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

        // 🌟 အရေးကြီးဆုံးအချက်: တစ်ကြိမ်လျှင် Message တစ်ခုသာ ယူရန် သတ်မှတ်ခြင်း (Prefetch 1)
        _channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var props = ea.BasicProperties;
            
            Console.WriteLine($"[Service 4 - Worker] ⏳ incoming processing task: {message}");

            try
            {
                // အလုပ်လုပ်နေကြောင်း Simulate လုပ်ရန် ၂ စက္ကန့် စောင့်ခိုင်းထားပါသည်
                await Task.Delay(2000);

                Console.WriteLine($"[Service 4 - Worker] ✅ Task processed.");

                // should reply to, callback queue
                var responsePayload = new
                {
                    target = "target@mail.com", // Ideally parsed from the incoming 'message'
                    status = "DELIVERED",
                    reason = "Sent successfully from .NET worker",
                    timestamp = DateTime.UtcNow
                };

                var responseBytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(responsePayload));

                Console.WriteLine($"[Service 4 - Worker] Replied JobID: {props.CorrelationId} - Status: DELIVERED");


                var replyTo = ea.BasicProperties.ReplyTo;
                var correlationId = ea.BasicProperties.CorrelationId;

                // _channel.BasicPublish(
                //     exchange: "",
                //     routingKey: replyTo,
                //     basicProperties: replyProps,
                //     body: responseBytes
                // );



                // 3. Publish the response to the ReplyTo queue
                // Use the default exchange ("") and the ReplyTo queue name as the routing key
                // _channel.BasicPublish(
                //     exchange: "",
                //     routingKey: props.ReplyTo,
                //     basicProperties: replyProps,
                //     body: responseBytes);


                // 🌟 အလုပ်ပြီးဆုံးကြောင်း RabbitMQ သို့ Manual အကြောင်းပြန်ခြင်း (Ack)
                _channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Service 4 - Worker] ❌ Error: {ex.Message}");
                // Error တက်ပါက Message ကို Queue ထဲ ပြန်ထည့်ရန် (Nack)
                _channel.BasicNack(deliveryTag: ea.DeliveryTag, multiple: false, requeue: true);
            }
        };

        // autoAck: false ပေးထားမှသာ Manual Ack သုံး၍ရမည်ဖြစ်သည်
        _channel.BasicConsume(queue: _queueName, autoAck: false, consumer: consumer);
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return Task.CompletedTask;
    }

    public override void Dispose()
    {
        _channel?.Close();
        _connection?.Close();
        base.Dispose();
    }
}