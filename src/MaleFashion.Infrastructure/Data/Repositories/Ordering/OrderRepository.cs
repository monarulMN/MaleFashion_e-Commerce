using MaleFahion.Application.Contracts.Repositories.Ordering;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Ordering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Ordering
{
    public class OrderRepository : Repository<Order, Guid>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
