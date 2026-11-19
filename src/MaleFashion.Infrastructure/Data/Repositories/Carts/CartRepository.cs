using MaleFahion.Application.Contracts.Repositories.Carts;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Carts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Carts
{
    public class CartRepository : Repository<Cart, Guid>, ICartRepository
    {
        public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
