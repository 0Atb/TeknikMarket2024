using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class ProductImage : AudiTableEntity, IBaseDomain
    {
        public int? ProductId { get; set; }
        public string? ImagePath { get; set; }
        public byte[]? Image { get; set; }

        public virtual Product? Product { get; set; }
    }
}
