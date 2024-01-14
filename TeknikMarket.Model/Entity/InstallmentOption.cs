using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class InstallmentOption : AudiTableEntity, IBaseDomain
    {
        public int? BankId { get; set; }
        public int? ProductId { get; set; }
        public int? InstallmentNumber { get; set; }

        public virtual Bank? Bank { get; set; }
        public virtual Product? Product { get; set; }
    }
}
