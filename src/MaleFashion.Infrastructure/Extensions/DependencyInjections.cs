using MaleFahion.Application.Contracts;
using MaleFahion.Application.Contracts.Repositories.Blogs;
using MaleFahion.Application.Contracts.Repositories.Carts;
using MaleFahion.Application.Contracts.Repositories.Catalogs;
using MaleFahion.Application.Contracts.Repositories.CMS;
using MaleFahion.Application.Contracts.Repositories.Customers;
using MaleFahion.Application.Contracts.Repositories.Ordering;
using MaleFahion.Application.Contracts.Repositories.Promotions;
using MaleFahion.Application.Contracts.Repositories.Supports;
using MaleFashion.Application.Contracts.Services;
using MaleFashion.Infrastructure.Data;
using MaleFashion.Infrastructure.Data.Repositories.Blogs;
using MaleFashion.Infrastructure.Data.Repositories.Carts;
using MaleFashion.Infrastructure.Data.Repositories.Catalogs;
using MaleFashion.Infrastructure.Data.Repositories.CMS;
using MaleFashion.Infrastructure.Data.Repositories.Customers;
using MaleFashion.Infrastructure.Data.Repositories.Ordering;
using MaleFashion.Infrastructure.Data.Repositories.Promotions;
using MaleFashion.Infrastructure.Data.Repositories.Supports;
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

            //Carts
            services.AddScoped<ICartRepository, CartRepository>();

            //CMS
            services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();
            services.AddScoped<IPartnerClientRepository, PartnerClientRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();

            //Customers
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            //Ordering
            services.AddScoped<IOrderRepository, OrderRepository>();

            //Promotions
            services.AddScoped<ICouponRepository, CouponRepository>();
            services.AddScoped<IDealCountdownRepository, DealCountdownRepository>();

            //Supports
            services.AddScoped<IContactInquiryRepository, ContactInquiryRepository>();
            services.AddScoped<INewsletterSubscriberRepository, NewsletterSubscriberRepository>();

            //Blogs
            services.AddScoped<IBlogPostRepository, BlogPostRepository>();



            return services;
        }
    }
}
