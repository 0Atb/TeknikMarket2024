using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Brand : AudiTableEntity, IBaseDomain
    {
        public string? Name { get; set; }
        public string? Explanation { get; set; }
        public string? CompanyImage { get; set; }
    }
}
