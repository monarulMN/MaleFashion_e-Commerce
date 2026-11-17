using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.Catalogs
{
    public interface IBrandRepository : IRepository<Brand, Guid>
    {
    }
}
