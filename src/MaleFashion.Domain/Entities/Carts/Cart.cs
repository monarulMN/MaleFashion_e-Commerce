using MaleFashion.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Domain.Entities.Carts
{
    public class Cart : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public Guid? CustomerId { get; set; }
        public string SessionId { get; set; } = string.Empty;
        public string? AppliedCouponCode { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<CartItem> items { get; set; } 
            = new List<CartItem>();

    }
}
