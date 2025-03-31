using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Security.Claims;

namespace CAPWebAPI.Authen;

public class WeChatAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    public WeChatAuthenticationHandler(
        IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        ISystemClock clock) : base(options, logger, encoder, clock)
    { }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        // 模拟获取微信扫码登录结果，实际场景中需要调用微信API验证
        var token = Request.Headers["WeChat-Token"].FirstOrDefault();
        if (string.IsNullOrEmpty(token))
        {
            return Task.FromResult(AuthenticateResult.NoResult());
        }
        if (token != "valid-wechat-token")
        {
            return Task.FromResult(AuthenticateResult.Fail("Invalid WeChat token"));
        }

        // 构造用户 Claims，可加入微信用户特有的信息
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, "WeChatUser"),
            new Claim("LoginType", "WeChat")
        };
        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);
        return Task.FromResult(AuthenticateResult.Success(ticket));
    }
}
