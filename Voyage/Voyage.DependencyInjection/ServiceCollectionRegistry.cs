using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Voyage.Business;
using Voyage.Business.Interfaces;
using Voyage.DataAccess.Context;
using Voyage.DataAccess.Interfaces;
using Voyage.DataAccess.Models;
using Voyage.DataAccess.Repositories;

namespace Voyage.DependencyInjection
{
    public static class ServiceCollectionRegistry
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("Default");
                options.UseSqlServer(connectionString);
            })
                .AddIdentity<AppUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<ITransportRepository, TransportRepository>();
        }

        public static void RegisterBusiness(this IServiceCollection services)
        {
            services.AddScoped<IService, Service>();
        }
    }
}