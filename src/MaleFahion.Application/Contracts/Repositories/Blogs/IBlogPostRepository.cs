using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.Blogs
{
    public interface IBlogPostRepository : IRepository<BlogPost, Guid>
    {
    }
}
