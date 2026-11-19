using MaleFahion.Application.Contracts.Repositories.Promotions;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Promotions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Promotions
{
    public class DealCountdownRepository : Repository<DealCountdown, Guid>, IDealCountdownRepository
    {
        public DealCountdownRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
