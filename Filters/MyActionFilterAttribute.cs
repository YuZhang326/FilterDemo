using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterDemo.Filters;

// 继承 Attribute，意味着是自定义属性 可以应用于控制器或者方法
public class MyActionFilterAttribute : Attribute, IActionFilter
{
    private readonly string _callerName;

    public MyActionFilterAttribute(string callerName)
    {
        _callerName = callerName;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($" {_callerName}    MyActionFilter    OnActionExecuted      2   ");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine($" {_callerName}    MyActionFilter    OnActionExecuting     1    ");
    }
}
