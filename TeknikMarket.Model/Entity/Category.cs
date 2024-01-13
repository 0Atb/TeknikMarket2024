using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Category
    {
        public Category()
        {
            InverseMainCategory = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? MainCategoryId { get; set; }
        public string? Information { get; set; }
        public int? Sorting { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Category? MainCategory { get; set; }
        public virtual ICollection<Category> InverseMainCategory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
