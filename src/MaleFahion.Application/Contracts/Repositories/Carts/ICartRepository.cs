using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.Carts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.Carts
{
    public interface ICartRepository : IRepository<Cart, Guid>
    {
    }
}
