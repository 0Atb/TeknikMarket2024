using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Bank
    {
        public Bank()
        {
            InstallmentOptions = new HashSet<InstallmentOption>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<InstallmentOption> InstallmentOptions { get; set; }
    }
}
