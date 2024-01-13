using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class OfferType
    {
        public OfferType()
        {
            Offers = new HashSet<Offer>();
        }

        public int Id { get; set; }
        public string? Type { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
