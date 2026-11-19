using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.Ordering;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.Ordering
{
    public interface IOrderRepository : IRepository<Order, Guid>
    {
    }
}
