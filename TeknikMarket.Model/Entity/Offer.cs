using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Offer
    {
        public Offer()
        {
            OrderOffers = new HashSet<OrderOffer>();
        }

        public int Id { get; set; }
        public string? Header { get; set; }
        public string? Explanation { get; set; }
        public int? OfferTypeId { get; set; }
        public decimal? OfferPrice { get; set; }
        public bool? SingularOffer { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual OfferType? OfferType { get; set; }
        public virtual ICollection<OrderOffer> OrderOffers { get; set; }
    }
}
