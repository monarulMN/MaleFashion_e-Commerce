using MaleFahion.Application.Contracts;
using MaleFahion.Application.Contracts.Repositories.Catalogs;
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


        public ApplicationUnitOfWork(ApplicationDbContext dbContext,
            ICategoryRepository categoryRepository,
            IProductRepository productRepository,
            IBrandRepository brandRepository) : base(dbContext)
        {
            CategoryRepository = categoryRepository;
            ProductRepository = productRepository;
            BrandRepository = brandRepository;
        }
    }
}
