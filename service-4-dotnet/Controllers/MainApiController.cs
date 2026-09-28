using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using RabbitMQ.Client;

namespace service_4_dotnet.Controllers;
 
[Route("/")]
public class MainApiController : ControllerBase
{

    [HttpGet(Name = "HelloWorld")]
    public IEnumerable<object> Get()
    {
        return [
            "API is up and running...",
            "What is this life if full of care?"
            ];
    }

    [HttpPost("publish")]
    public IActionResult PublishEvent()
    {
        var factory = new ConnectionFactory { HostName = "rabbitmq-server" };
        
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        string exchangeName = "person_events";
        
        // Ensure the exchange exists
        channel.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Fanout, durable: false);

        var messageData = new 
        { 
            action = "USER_REGISTERED", 
            email = "hello@drtoken.live",
            timestamp = DateTime.UtcNow 
        };
        
        var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(messageData));

        // Publish to the exchange
        channel.BasicPublish(
            exchange: exchangeName,
            routingKey: "", 
            basicProperties: null,
            body: body);

        return Ok(new 
        { 
            status = "Success", 
            message = $"Published event to {exchangeName} exchange.",
            payload = messageData 
        });
    }

}
