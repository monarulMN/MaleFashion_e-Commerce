using MaleFahion.Application.Contracts.Repositories.Blogs;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Blogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Blogs
{
    public class BlogPostRepository : Repository<BlogPost, Guid>, IBlogPostRepository
    {
        public BlogPostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
