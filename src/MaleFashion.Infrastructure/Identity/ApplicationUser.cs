using MaleFashion.Domain.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<Guid>, IAggregateRoot<Guid>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        

    }
}
