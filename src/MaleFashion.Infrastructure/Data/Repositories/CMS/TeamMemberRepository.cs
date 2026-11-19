using MaleFahion.Application.Contracts.Repositories.CMS;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.CMS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.CMS
{
    public class TeamMemberRepository : Repository<TeamMember, Guid>, ITeamMemberRepository
    {
        public TeamMemberRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
