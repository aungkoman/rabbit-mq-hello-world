using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace service_4_dotnet.Services;

public class RabbitMqWorkerService : BackgroundService
{
    private IConnection? _connection;
    private IChannel? _channel;

    private readonly string _queueName = "email_service_queue";

    protected override async Task ExecuteAsync(
        CancellationToken stoppingToken)
    {
        try
        {
            // ---------------------------------------
            // 1. Connect to RabbitMQ
            // ---------------------------------------

            var factory = new ConnectionFactory
            {
                HostName = "rabbitmq-server"
            };

            _connection = await factory.CreateConnectionAsync(
                stoppingToken
            );

            _channel = await _connection.CreateChannelAsync(
                cancellationToken: stoppingToken
            );

            Console.WriteLine(
                "[Service 4 - Worker] 🟢 Connected to RabbitMQ"
            );

            // ---------------------------------------
            // 2. Declare email queue
            // ---------------------------------------

            await _channel.QueueDeclareAsync(
                queue: _queueName,
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null,
                cancellationToken: stoppingToken
            );

            // ---------------------------------------
            // 3. Prefetch = 1
            // ---------------------------------------

            await _channel.BasicQosAsync(
                prefetchSize: 0,
                prefetchCount: 1,
                global: false,
                cancellationToken: stoppingToken
            );

            Console.WriteLine(
                $"[Service 4 - Worker] 📥 Waiting for jobs on: {_queueName}"
            );

            // ---------------------------------------
            // 4. Create async consumer
            // ---------------------------------------

            var consumer = new AsyncEventingBasicConsumer(
                _channel
            );

            consumer.ReceivedAsync += async (model, ea) =>
            {
                await ProcessMessageAsync(ea);
            };

            // ---------------------------------------
            // 5. Start consuming
            // ---------------------------------------

            await _channel.BasicConsumeAsync(
                queue: _queueName,
                autoAck: false,
                consumer: consumer,
                cancellationToken: stoppingToken
            );

            // Keep worker alive
            await Task.Delay(
                Timeout.Infinite,
                stoppingToken
            );
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine(
                "[Service 4 - Worker] 🛑 Worker stopping..."
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"[Service 4 - Worker] ❌ RabbitMQ error: {ex.Message}"
            );
        }
    }

    private async Task ProcessMessageAsync(
        BasicDeliverEventArgs ea)
    {
        if (_channel == null)
        {
            Console.WriteLine(
                "[Service 4 - Worker] ❌ Channel is not available."
            );

            return;
        }

        var body = ea.Body.ToArray();

        var message = Encoding.UTF8.GetString(body);

        Console.WriteLine(
            $"[Service 4 - Worker] ⏳ Incoming task: {message}"
        );

        try
        {
            // ---------------------------------------
            // 1. Get RabbitMQ properties
            // ---------------------------------------

            var replyTo = ea.BasicProperties.ReplyTo;

            var correlationId =
                ea.BasicProperties.CorrelationId;

            Console.WriteLine(
                $"[Service 4 - Worker] 📮 ReplyTo: {replyTo}"
            );

            Console.WriteLine(
                $"[Service 4 - Worker] 🔗 CorrelationId: {correlationId}"
            );

            // ---------------------------------------
            // 2. Parse incoming JSON
            // ---------------------------------------

            string? email = null;

            try
            {
                using var json =
                    JsonDocument.Parse(message);

                var root = json.RootElement;

                if (root.TryGetProperty(
                    "email",
                    out var emailProperty))
                {
                    email = emailProperty.GetString();
                }
            }
            catch (JsonException)
            {
                Console.WriteLine(
                    "[Service 4 - Worker] ⚠️ Invalid JSON."
                );
            }

            Console.WriteLine(
                $"[Service 4 - Worker] 📧 Email: {email}"
            );

            // ---------------------------------------
            // 3. Simulate email processing
            // ---------------------------------------

            await Task.Delay(2000);

            Console.WriteLine(
                "[Service 4 - Worker] ✅ Task processed."
            );

            // ---------------------------------------
            // 4. Create response payload
            // ---------------------------------------

            var responsePayload = new
            {
                target = email ?? "target@mail.com",

                status = "DELIVERED",

                reason =
                    "Sent successfully from .NET worker",

                timestamp = DateTime.UtcNow
            };

            var responseJson =
                JsonSerializer.Serialize(
                    responsePayload
                );

            var responseBytes =
                Encoding.UTF8.GetBytes(
                    responseJson
                );

            // ---------------------------------------
            // 5. Reply to ReplyTo queue
            // ---------------------------------------

            if (!string.IsNullOrEmpty(replyTo))
            {
                var replyProps =
                    new BasicProperties();

                // IMPORTANT:
                // Return original CorrelationId
                replyProps.CorrelationId =
                    correlationId;

                // Default exchange:
                //
                // exchange = ""
                // routingKey = ReplyTo queue
                //

                await _channel.BasicPublishAsync(
                    exchange: "",
                    routingKey: replyTo,
                    mandatory: false,
                    basicProperties: replyProps,
                    body: responseBytes
                );

                Console.WriteLine(
                    $"[Service 4 - Worker] 📤 Reply sent to: {replyTo}"
                );

                Console.WriteLine(
                    $"[Service 4 - Worker] 🔗 JobID: {correlationId}"
                );

                Console.WriteLine(
                    $"[Service 4 - Worker] 📦 Response: {responseJson}"
                );
            }
            else
            {
                Console.WriteLine(
                    "[Service 4 - Worker] ⚠️ ReplyTo is empty."
                );
            }

            // ---------------------------------------
            // 6. ACK original message
            // ---------------------------------------

            await _channel.BasicAckAsync(
                deliveryTag: ea.DeliveryTag,
                multiple: false
            );

            Console.WriteLine(
                $"[Service 4 - Worker] ✅ ACK: {correlationId}"
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"[Service 4 - Worker] ❌ Processing error: {ex.Message}"
            );

            // ---------------------------------------
            // NACK + requeue
            // ---------------------------------------

            await _channel.BasicNackAsync(
                deliveryTag: ea.DeliveryTag,
                multiple: false,
                requeue: true
            );
        }
    }

    public override void Dispose()
    {
        try
        {
            _channel?.CloseAsync().GetAwaiter().GetResult();
        }
        catch
        {
            // Ignore shutdown errors
        }

        try
        {
            _connection?.CloseAsync().GetAwaiter().GetResult();
        }
        catch
        {
            // Ignore shutdown errors
        }

        base.Dispose();
    }
}