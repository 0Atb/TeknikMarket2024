using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Bank : AudiTableEntity, IBaseDomain
    {
        public Bank()
        {
            InstallmentOptions = new HashSet<InstallmentOption>();
        }

        public string? Name { get; set; }
        public string? Icon { get; set; }

        public virtual ICollection<InstallmentOption> InstallmentOptions { get; set; }
    }
}
