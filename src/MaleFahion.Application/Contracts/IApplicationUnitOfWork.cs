using MaleFahion.Application.Contracts.Repositories.Catalogs;
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

    }
}
