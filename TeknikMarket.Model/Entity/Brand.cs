using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Brand
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Explanation { get; set; }
        public string? CompanyImage { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
