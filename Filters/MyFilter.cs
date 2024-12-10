using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterDemo.Filters;

public class MyFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($"Global    OnActionExecuted      2   ");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine($"Global    OnActionExecuting     1    ");
    }
}
