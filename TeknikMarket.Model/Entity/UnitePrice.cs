using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class UnitePrice
    {
        public int Id { get; set; }
        public string? UniteName { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
