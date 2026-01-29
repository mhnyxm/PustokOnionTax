using Pustok.Business.DTOs;

namespace Pustok.Presentation.Middlewares;

public class GlobalExceptionHandler
{
    private readonly RequestDelegate _next;

    public GlobalExceptionHandler(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            ResultDTO errorResult = new ResultDTO
            {
                StatusCode = 999,
                Message = ex.Message,
                IsSucced = false
            };
           
            await context.Response.WriteAsJsonAsync(errorResult);
        }
    }
}
