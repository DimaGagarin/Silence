using Meetup.Business;
using Meetup.Business.Interfaces;
using Meetup.DataAccess;
using Meetup.DataAccess.Interfaces;
using Meetup.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Meetup.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MeetupContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IRepository, Repository>();
        }

        public static void RegisterBusiness(this IServiceCollection services)
        {
            services.AddScoped<IService, Service>();
        }
    }
}