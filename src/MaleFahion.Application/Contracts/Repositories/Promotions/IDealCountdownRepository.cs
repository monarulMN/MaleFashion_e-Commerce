using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.Promotions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.Promotions
{
    public interface IDealCountdownRepository : IRepository<DealCountdown, Guid>
    {
    }
}
