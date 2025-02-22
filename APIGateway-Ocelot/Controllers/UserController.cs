using APIGateway_Ocelot.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIGateway_Ocelot.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    [HttpGet]
    public List<User> Get()
    {
        Console.WriteLine("Success");
        var result = new List<User>
        {
            new("test1", "thuan2"),
            new("test2", "thuan2")
        };
        return result;

    }
}