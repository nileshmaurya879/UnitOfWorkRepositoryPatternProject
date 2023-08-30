using System.Runtime.CompilerServices;
using UnitOfWorkRepositoryPatternProject.Interface;
using UnitOfWorkRepositoryPatternProject.Repository;
using UnitOfWorkRepositoryPatternProject.Services;

namespace UnitOfWorkRepositoryPatternProject.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
