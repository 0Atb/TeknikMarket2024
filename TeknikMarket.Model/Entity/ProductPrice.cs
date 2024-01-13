using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class ProductPrice
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? Header { get; set; }
        public string? Explanation { get; set; }
        public decimal? Price { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Product? Product { get; set; }
    }
}
