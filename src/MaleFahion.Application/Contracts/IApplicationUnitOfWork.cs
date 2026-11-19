using MaleFahion.Application.Contracts.Repositories.Blogs;
using MaleFahion.Application.Contracts.Repositories.Carts;
using MaleFahion.Application.Contracts.Repositories.Catalogs;
using MaleFahion.Application.Contracts.Repositories.CMS;
using MaleFahion.Application.Contracts.Repositories.Customers;
using MaleFahion.Application.Contracts.Repositories.Ordering;
using MaleFahion.Application.Contracts.Repositories.Promotions;
using MaleFahion.Application.Contracts.Repositories.Supports;
using MaleFashion.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        //Calalogs
        public ICategoryRepository CategoryRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IBrandRepository BrandRepository { get; }

        //Carts
        public ICartRepository CartRepository { get; }

        //CMS
        public ITeamMemberRepository TeamMemberRepository { get; }
        public IPartnerClientRepository PartnerClientRepository { get; }
        public ITestimonialRepository TestimonialRepository { get; }

        //Customers
        public ICustomerRepository CustomerRepository { get; }

        //Order
        public IOrderRepository OrderRepository { get; }

        //Promotions
        public ICouponRepository CouponRepository { get; }
        public IDealCountdownRepository DealCountdownRepository { get; }

        //Supports
        public IContactInquiryRepository ContactInquiryRepository { get; }
        public INewsletterSubscriberRepository NewsletterSubscriberRepository { get; }

        //Blogs
        public IBlogPostRepository BlogPostRepository { get; }

    }
}
