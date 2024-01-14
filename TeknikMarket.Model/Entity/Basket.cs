using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Basket : AudiTableEntity, IBaseDomain
    {
        public int? ProductId { get; set; }
        public int? Piece { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Product? Product { get; set; }
    }
}
