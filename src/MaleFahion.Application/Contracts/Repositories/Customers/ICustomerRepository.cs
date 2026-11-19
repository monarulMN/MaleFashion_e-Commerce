using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFahion.Application.Contracts.Repositories.Customers
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
    }
}
