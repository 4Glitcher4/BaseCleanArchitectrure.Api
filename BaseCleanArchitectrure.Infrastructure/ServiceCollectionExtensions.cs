using BaseCleanArchitectrure.Core.Interfaces.RepositoryInterfaces;
using BaseCleanArchitectrure.Infrastructure.Contexts;
using BaseCleanArchitectrure.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BaseCleanArchitectrure.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        private static IServiceCollection AddConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        private static IServiceCollection AddSingletonServices(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddScoppedServices(this IServiceCollection services)
        {
            return services;
        }

        public static IHostApplicationBuilder AddPersistense(this IHostApplicationBuilder builder)
        {
            builder.Services.AddEntityFrameworkNpgsql()
                .AddDbContext<ApplicationDbContext>(
                    dbContextOptions => dbContextOptions.UseNpgsql(builder.Configuration.GetSection("ConnectionStrings:DbConnection").Value));

            builder.Services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));

            return builder;
        }
    }
}
