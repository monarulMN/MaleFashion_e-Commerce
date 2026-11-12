using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.Enums;
using MaleFashion.Domain.ValueOfObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Domain.Entities.Ordering
{
    public class Order : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public Guid? CustomerId { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public Address BillingAddress { get; set; } = default!;
        public Address ShippingAddress { get; set; } = default!;
        public Money SubTotal { get; set; } = default!;
        public Money TotalAmount { get; set; } = default!;
        public PaymentMethod PaymentMethod { get; set; }
        public string? OrderNotes { get; set; }
        public Guid? CouponId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public ICollection<OrderItem> OrderItems { get; set; } 
            = new List<OrderItem>();
    }
}
