using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace CAPWebAPI.controller;

[Route("api/wechat")]
[ApiController]
[Authorize(AuthenticationSchemes = "WeChatScheme",Policy = "admin")]
public class WeChatController : ControllerBase
{
    [HttpGet("userinfo")]
    public IActionResult GetUserInfo()
    {
        return Ok(new { message = "微信用户登录成功", user = User.Identity?.Name });
    }
}