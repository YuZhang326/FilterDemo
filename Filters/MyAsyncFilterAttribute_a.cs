using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterDemo.Filters;

public class MyAsyncFilterAttribute_a : Attribute, IAsyncActionFilter
{
    private readonly string _callName;

    public MyAsyncFilterAttribute_a(string callName)
    {
        _callName = callName;
    }

    // ActionExecutionDelegate 通过这个Delegate调用下一个函数
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine($" {_callName} Async filter Duing 1");
        await next();
        // 调用的函数执行结束以后才会执行这里
        Console.WriteLine($" {_callName} Async filter Duing 2");
    }
}
