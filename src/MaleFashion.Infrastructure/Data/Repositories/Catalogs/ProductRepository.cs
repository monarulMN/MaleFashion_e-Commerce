using MaleFahion.Application.Contracts.Repositories.Catalogs;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Catalogs
{
    public class ProductRepository : Repository<Product, Guid>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
