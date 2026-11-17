using MaleFahion.Application.Contracts;
using MaleFahion.Application.Contracts.Repositories.Catalogs;
using MaleFashion.Application.Contracts.Services;
using MaleFashion.Infrastructure.Data;
using MaleFashion.Infrastructure.Data.Repositories.Catalogs;
using MaleFashion.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services, string rootPath)
        {
            services.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
            services.AddSingleton<IFileStorageService, FileStorageService>( x => 
                new FileStorageService(rootPath));

            //Catalog
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();



            return services;
        }
    }
}
