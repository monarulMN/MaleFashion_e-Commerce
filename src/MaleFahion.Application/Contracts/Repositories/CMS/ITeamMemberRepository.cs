using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.CMS
{
    public interface ITeamMemberRepository : IRepository<TeamMember, Guid>
    {
    }
}
