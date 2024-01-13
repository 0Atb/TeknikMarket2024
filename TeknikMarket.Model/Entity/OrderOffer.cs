using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class OrderOffer
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? OfferId { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Offer? Offer { get; set; }
        public virtual Order? Order { get; set; }
    }
}
