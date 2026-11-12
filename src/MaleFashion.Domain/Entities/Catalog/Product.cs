using MaleFashion.Domain.Contracts;
using MaleFashion.Domain.ValueOfObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Domain.Entities.Catalog
{
    public class Product : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? AdditionalInformation { get; set; }
        public string Sku { get; set; } = string.Empty;
        public Money BasePrice { get; set; } = default!;
        public Money? SalePrice { get; set; } 
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsHostSale { get; set; }
        public double Rating { get; set; }

        public ICollection<ProductImage> Images { get; set; } 
            = new List<ProductImage>();

        public ICollection<ProductVariant> Variants { get; set; }
            = new List<ProductVariant>();

        public ICollection<ProductTag> Tags { get; set; }
            = new List<ProductTag>();
    }
}
