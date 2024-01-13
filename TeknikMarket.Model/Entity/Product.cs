using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Product
    {
        public Product()
        {
            Baskets = new HashSet<Basket>();
            InstallmentOptions = new HashSet<InstallmentOption>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductImages = new HashSet<ProductImage>();
            ProductPrices = new HashSet<ProductPrice>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Explanation { get; set; }
        public int? CategoriyId { get; set; }
        public int? Stock { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Category? Categoriy { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<InstallmentOption> InstallmentOptions { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
