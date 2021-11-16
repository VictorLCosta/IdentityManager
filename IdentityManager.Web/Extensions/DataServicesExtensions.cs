using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityManager.Web.Extensions
{
    public static class DataServicesExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration config)
        {
            

            return services;
        }
    }
}
