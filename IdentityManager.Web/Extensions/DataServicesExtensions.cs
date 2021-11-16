using System;
using IdentityManager.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using IdentityManager.Web.Entities;

namespace IdentityManager.Web.Extensions
{
    public static class DataServicesExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection")) 
            );

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.UpgradePasswordSecurity().UseArgon2<AppUser>();

            return services;
        }
    }
}
