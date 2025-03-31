using Microsoft.AspNetCore.Mvc;
namespace WebApplicationWithSerialog.controller;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;

    public OrderController(ILogger<OrderController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id}")]
    public IActionResult GetOrder(int id)
    {
        _logger.LogInformation("开始处理订单请求: {OrderId}", id);
        
        var order = new { Id = id, Status = "Processing" };

        _logger.LogInformation("订单请求处理完成: {OrderId}", id);
        return Ok(order);
    }
}
