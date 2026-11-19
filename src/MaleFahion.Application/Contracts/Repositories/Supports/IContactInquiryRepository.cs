using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.Support;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.Supports
{
    public interface IContactInquiryRepository : IRepository<ContactInquiry, Guid>
    {
    }
}
