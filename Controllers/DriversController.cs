using FilterDemo.Filters;
using Microsoft.AspNetCore.Mvc;

namespace FilterDemo;

[ApiController]
[Route("[controller]")]
[MyActionFilterAttribute("DriversController")] // 自己创建的和DriversController绑定
public class DriversController : ControllerBase
{
    private static List<string> drivers = new List<string>(){
        "Ha Ha",
        "He He",
        "Hei Hei"
    };

    [HttpGet(Name = "GetDtivers")]
    [MyActionFilterAttribute("GetDtivers haha")] // 这个名字随便
    [MyAsyncFilterAttribute_a("GetDtivers Attribute_a")]
    [MyAsyncFilterAttribute_b("GetDtivers Attribute_b")]
    public IActionResult Get()
    {
        return Ok(drivers);
    }

    [HttpPost(Name = "AddDriver")]
    public IActionResult Post(string driverName)
    {
        drivers.Add(driverName);
        return Ok(drivers);
    }
}
