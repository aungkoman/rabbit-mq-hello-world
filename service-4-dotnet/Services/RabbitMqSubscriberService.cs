using System.Text;
using System.Text.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using service_4_dotnet.Data;
using service_4_dotnet.Models;

namespace service_4_dotnet.Services;

// BackgroundService ကိုသုံးခြင်းဖြင့် API Run နေစဉ် နောက်ကွယ်မှ RabbitMQ ကို အမြဲနားထောင်နေပါမည်
public class RabbitMqSubscriberService : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private IConnection? _connection;
    private IModel? _channel;

    public RabbitMqSubscriberService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
        InitRabbitMQ();
    }

    private void InitRabbitMQ()
    {
        // docker-compose ထဲက RabbitMQ Service နာမည်ကို ချိတ်ဆက်ခြင်း
        var factory = new ConnectionFactory { HostName = "rabbitmq-server" }; 
        // Connection ချိတ်
        _connection = factory.CreateConnection();
        // Channel ဆောက်၊ ဒါက Express / Hono ဘက်မှာလည်း အတူတူလုပ်ခဲ့တဲ့ ကိစ္စ။
        _channel = _connection.CreateModel();

        // Service 1/2 တို့တွင် သုံးခဲ့သည့် Exchange အမည်ကို ဤနေရာတွင် ထည့်ပေးပါ (ဥပမာ - "person_events")
        // ဒါတွေ အကုန်ုလုံးက doc မှာ ပဲ ဖြစ်ဖြစ် စုတော့ ထားသင့်တယ်။
        var exchangeName = "person_events"; 
        // ဒီမှာတော့ assert တွေ ဘာတွေ မလုပ်တော့ဘူး။ ဒီအတိုင်း တန်း ကြေငြာတာမျိုးလား?
        _channel.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Fanout);

        // Random Queue အလွတ်တစ်ခုဆောက်ပြီး Exchange နှင့် ချိတ်ဆက်ခြင်း
        // random queue တစ်ခုဆောက်
        var queueName = _channel.QueueDeclare().QueueName;
        // အပေါ်က exchange နဲ့ bind
        _channel.QueueBind(queue: queueName, exchange: exchangeName, routingKey: "");


        // ဒါက consumer တစ်ခု အရင် ကြေငြာ
        // ဒီ consumer က data ရရင် ဘာတွေ လုပ်မယ် ဆိုပြီး ကြိုတင်ကြေငြာထားတာ။
        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += async (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine($"[Service 4] Received Message: {message}");

            await ProcessMessage(message);
        };



        // ဒါက ဒဲ့ consumer ကို queue နဲ့ ချိတ်ဆက်ပေးတာ
        // ပြဿနာက ဘယ် queue ကို listen လုပ်မယ်ဆိုတာ ကြေငြာမထားဘူးပဲ။
        // အော် queue ဆိုပြီး ဘယ် queue ကို စောင့်မယ်ဆိုတာ ပြေထားတာပဲ။
        // ဒါက random queue
        _channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
    }

    private async Task ProcessMessage(string message)
    {
        // Background Service ဖြစ်၍ In-Memory DB ကို ခေါ်သုံးရန် Scope အသစ်ဖန်တီးရပါသည်
        // scope ဆိုတာ muti threading ကို ပြောချင်တာလား?
        using var scope = _scopeFactory.CreateScope();
        // Injection လုပ်ထားတဲ့ service တွေကို စခေါ်သုံး။ scope / thread ကြောင့်မို့ ခေါ်နိုင်တာလား?
        // main thread မှာတော့ မဟုတ်တာ သေချာတယ်။
        // သီးသန့် program တစ်ပုဒ် run နေရသလိုပဲ။
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        try
        {
            // JSON ကို Person Object အဖြစ် ပြောင်းခြင်း
            var person = JsonSerializer.Deserialize<Person>(message, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            
            if (person != null)
            {
                person.Id = 0; // ID ကို 0 ထားမှ DB က အလိုအလျောက် အသစ်သတ်မှတ်ပေးမည်
                dbContext.Persons.Add(person);
                await dbContext.SaveChangesAsync();
                Console.WriteLine($"[Service 4] Successfully saved person to DB: {person.Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Service 4] Error processing message: {ex.Message}");
        }
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