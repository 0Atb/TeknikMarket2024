using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class OrderDetail : AudiTableEntity, IBaseDomain
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Piece { get; set; }
        public int? UnitPrice { get; set; }
        public int? Sale { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
