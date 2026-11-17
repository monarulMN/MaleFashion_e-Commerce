using MaleFahion.Application.Contracts.Repositories.Catalogs;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Catalogs
{
    public class CategoryRepository : Repository<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
