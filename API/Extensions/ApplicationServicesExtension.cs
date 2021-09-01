using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(option =>
          {
              option.UseSqlite(config.GetConnectionString("DefaultConnection"));
          });
            services.AddScoped<ITokenService, TokenService>();


            return services;
        }
    }
}