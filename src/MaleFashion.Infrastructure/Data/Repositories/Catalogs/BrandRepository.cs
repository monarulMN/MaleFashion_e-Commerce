using MaleFahion.Application.Contracts.Repositories.Catalogs;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Catalogs
{
    public class BrandRepository : Repository<Brand, Guid>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
