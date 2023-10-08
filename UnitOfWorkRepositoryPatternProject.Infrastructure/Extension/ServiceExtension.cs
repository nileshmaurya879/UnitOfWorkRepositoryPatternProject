using Microsoft.Extensions.DependencyInjection;
using UnitOfWorkRepositoryPatternProject.Core.Interface;
using UnitOfWorkRepositoryPatternProject.Infrastructure.Repository;
using UnitOfWorkRepositoryPatternProject.Infrastructure.Repository.Products;
using UnitOfWorkRepositoryPatternProject.Service.Interface;
using UnitOfWorkRepositoryPatternProject.Service.Services;

namespace UnitOfWorkRepositoryPatternProject.Infrastructure.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
