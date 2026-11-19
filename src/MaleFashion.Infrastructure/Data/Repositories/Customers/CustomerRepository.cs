using MaleFahion.Application.Contracts.Repositories.Customers;
using Malefashion.Infrastructure.Data;
using MaleFashion.Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Data.Repositories.Customers
{
    public class CustomerRepository : Repository<Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
