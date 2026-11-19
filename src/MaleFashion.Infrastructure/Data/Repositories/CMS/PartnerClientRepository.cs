using MaleFahion.Application.Contracts.Repositories.CMS;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.CMS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.CMS
{
    public class PartnerClientRepository : Repository<PartnerClient, Guid>, IPartnerClientRepository
    {
        public PartnerClientRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
