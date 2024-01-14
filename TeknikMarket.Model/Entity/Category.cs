using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Category : AudiTableEntity, IBaseDomain
    {
        public Category()
        {
            InverseMainCategory = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public string? Name { get; set; }
        public int? MainCategoryId { get; set; }
        public string? Information { get; set; }
        public int? Sorting { get; set; }

        public virtual Category? MainCategory { get; set; }
        public virtual ICollection<Category> InverseMainCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
