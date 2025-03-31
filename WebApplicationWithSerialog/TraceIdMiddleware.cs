using Serilog.Context;
namespace WebApplicationWithSerialog;

public class TraceIdMiddleware
{
    private readonly RequestDelegate _next;

    public TraceIdMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var traceId = context.TraceIdentifier;  // ASP.NET Core 自带的 TraceId
        if (!context.Request.Headers.ContainsKey("X-Trace-Id"))
        {
            traceId = Guid.NewGuid().ToString();  // 生成新的 TraceId
            context.TraceIdentifier = traceId;
            context.Request.Headers["X-Trace-Id"] = traceId;  // 传递给后续请求
        }
        else
        {
            traceId = context.Request.Headers["X-Trace-Id"];
            context.TraceIdentifier = traceId;  // 统一 TraceId
        }

        // 在日志上下文中存储 TraceId
        using (LogContext.PushProperty("TraceId", traceId))
        {
            await _next(context);
        }
    }
}
