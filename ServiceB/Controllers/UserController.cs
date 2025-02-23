using Microsoft.AspNetCore.Mvc;

namespace ServiceB.Controllers;
[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        // Console.WriteLine("Success");
        // var result = new List<User>
        // {
        //     new("test1", "thuan2"),
        //     new("test2", "thuan2")
        // };
        return "Service B";

    }
}