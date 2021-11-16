using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityManager.Web.Extensions
{
    public static class WebServicesExtensions
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();;

            return services;
        }
    }
}
