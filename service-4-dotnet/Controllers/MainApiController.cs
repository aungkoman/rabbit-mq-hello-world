using Microsoft.AspNetCore.Mvc;

namespace service_4_dotnet.Controllers;
 
[Route("/")]
public class MainApiController : ControllerBase
{

    [HttpGet(Name = "HelloWorld")]
    public IEnumerable<object> Get()
    {
        return ["API is up and running..."];
    }
}
