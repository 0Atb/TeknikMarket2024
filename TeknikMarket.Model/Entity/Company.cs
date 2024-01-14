using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Company:AudiTableEntity, IBaseDomain
    {
        public int? UserId { get; set; }
        public string? Name { get; set; }
        public string? TaxNumber { get; set; }
        public string? TaxOffice { get; set; }
        public string? Tcno { get; set; }

        public virtual User? User { get; set; }
    }
}
