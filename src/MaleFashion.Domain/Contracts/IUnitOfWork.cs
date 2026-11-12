using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Domain.Contracts
{
    public interface IUnitOfWork
    {
        void Save(CancellationToken cancellationToken);
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
