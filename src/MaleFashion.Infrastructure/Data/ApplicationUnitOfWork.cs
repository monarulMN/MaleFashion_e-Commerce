using MaleFahion.Application.Contracts;
using MaleFahion.Application.Contracts.Repositories.Blogs;
using MaleFahion.Application.Contracts.Repositories.Carts;
using MaleFahion.Application.Contracts.Repositories.Catalogs;
using MaleFahion.Application.Contracts.Repositories.CMS;
using MaleFahion.Application.Contracts.Repositories.Customers;
using MaleFahion.Application.Contracts.Repositories.Ordering;
using MaleFahion.Application.Contracts.Repositories.Promotions;
using MaleFahion.Application.Contracts.Repositories.Supports;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        //catalog
        public ICategoryRepository CategoryRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public IBrandRepository BrandRepository { get; private set; }

        //Carts
        public ICartRepository CartRepository { get; private set; }

        //CMS
        public ITeamMemberRepository TeamMemberRepository { get; private set; }
        public IPartnerClientRepository PartnerClientRepository { get; private set; }
        public ITestimonialRepository TestimonialRepository { get; private set; }

        //Customers
        public ICustomerRepository CustomerRepository { get; private set; }

        //Ordering
        public IOrderRepository OrderRepository { get; private set; }

        //Promotions
        public ICouponRepository CouponRepository { get; private set; }
        public IDealCountdownRepository DealCountdownRepository { get; private set; }

        //Supports
        public IContactInquiryRepository ContactInquiryRepository { get; private set; }
        public INewsletterSubscriberRepository NewsletterSubscriberRepository { get; private set; }

        //Blogs
        public IBlogPostRepository BlogPostRepository { get; private set; }


        public ApplicationUnitOfWork(ApplicationDbContext dbContext,
            ICategoryRepository categoryRepository,
            IProductRepository productRepository,
            IBrandRepository brandRepository,
            ICartRepository cartRepository,
            ITeamMemberRepository teamMemberRepository,
            IPartnerClientRepository partnerClientRepository,
            ITestimonialRepository testimonialRepository,
            ICustomerRepository customerRepository,
            IOrderRepository orderRepository,
            ICouponRepository couponRepository,
            IDealCountdownRepository dealCountdownRepository,
            IContactInquiryRepository contactInquiryRepository,
            INewsletterSubscriberRepository newsletterSubscriberRepository,
            IBlogPostRepository blogPostRepository) : base(dbContext)
        {
            CategoryRepository = categoryRepository;
            ProductRepository = productRepository;
            BrandRepository = brandRepository;
            CartRepository = cartRepository;
            TeamMemberRepository = teamMemberRepository;
            PartnerClientRepository = partnerClientRepository;
            TestimonialRepository = testimonialRepository;
            CustomerRepository = customerRepository;
            OrderRepository = orderRepository;
            CouponRepository = couponRepository;
            DealCountdownRepository = dealCountdownRepository;
            ContactInquiryRepository = contactInquiryRepository;
            NewsletterSubscriberRepository = newsletterSubscriberRepository;
            BlogPostRepository = blogPostRepository;
        }
    }
}
