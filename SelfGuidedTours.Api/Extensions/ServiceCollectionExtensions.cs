using Microsoft.AspNetCore.Identity;
using SelfGuidedTours.Infrastructure.Data.Models;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //Inject services here
            return services;
        }
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            //TODO: add context here
            //services.AddDbContext<ApplicationDbContext>(options =>
            //{
            //    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            //});

            return services;
        }
        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {

            services.AddIdentityCore<ApplicationUser>()
                .AddRoles<IdentityRole>();
            //TODO: Add token provider and default stores


            //Password requirements
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 1;
            });


            return services;
        }
    }
}
