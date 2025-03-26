

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsulTemplate;

public static class CorsServiceExtensions
{
    private readonly static string PolicyName = "MCodeCors";

    /// <summary>
    /// 添加跨域
    /// </summary>
    /// <param name="services">服务集合</param>
    /// <returns></returns>
    public static IServiceCollection AddMCodeCors(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));
        //origin microsoft.aspnetcore.cors      
        return services.AddCors(options =>
        {
            options.AddPolicy(PolicyName,
                policy =>
                {
                    policy.SetIsOriginAllowed(_ => true).AllowAnyMethod().AllowAnyHeader().AllowCredentials();
                });
        });
    }

    /// <summary>
    /// 使用跨域
    /// </summary>
    /// <param name="app">应用程序建造者</param>
    /// <returns></returns>
    public static IApplicationBuilder UseMCodeCors(this IApplicationBuilder app)
    {
        return app.UseCors(PolicyName);
    }
}
