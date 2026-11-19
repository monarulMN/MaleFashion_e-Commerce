using MaleFahion.Application.Contracts.Repositories.Supports;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Support;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Supports
{
    public class NewsletterSubscriberRepository : Repository<NewsletterSubscriber, Guid>, INewsletterSubscriberRepository
    {
        public NewsletterSubscriberRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
