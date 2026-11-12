using MaleFahion.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services)
        {
            //services.AddScoped<IApplicationUnitOfWork, IApplicationUnitOfWork>();

            return services;
        }
    }
}
