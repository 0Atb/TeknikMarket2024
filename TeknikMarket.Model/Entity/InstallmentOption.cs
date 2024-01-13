using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class InstallmentOption
    {
        public int Id { get; set; }
        public int? BankId { get; set; }
        public int? ProductId { get; set; }
        public int? InstallmentNumber { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Bank? Bank { get; set; }
        public virtual Product? Product { get; set; }
    }
}
