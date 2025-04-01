using CAPWebAPI.Model;
using Microsoft.AspNetCore.Mvc;
namespace CAPWebAPI.controller;

[Route("api/userInfo")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] UserModel model)
    {
        /*
        if (!ModelState.IsValid)
        {
            // 返回错误信息给前端
            return BadRequest(ModelState);
        }
        */
    
        // 业务逻辑处理
        return Ok();
    }
}

