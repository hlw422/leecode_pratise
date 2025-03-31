using System.Net;
using System.Text.Json;
namespace CAPWebAPI.Exception;
using System;

public class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<GlobalExceptionMiddleware> _logger;

    public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            // 继续执行下一个中间件
            await _next(context);
        }
        catch (Exception ex)
        {
            // 记录详细错误日志，便于排查问题
            _logger.LogError(ex.ToString(), "Unhandled exception");
            // 返回统一的错误信息给客户端，避免暴露内部实现细节
            await HandleExceptionAsync(context);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context)
    {
        // 设置响应状态码为 500 并返回通用错误信息
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = "application/json";
        var result = JsonSerializer.Serialize(new { error = "系统繁忙，请稍后重试" });
        return context.Response.WriteAsync(result);
    }
}
