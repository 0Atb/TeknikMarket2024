using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            OrderOffers = new HashSet<OrderOffer>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
        public decimal? TotalOrderPrice { get; set; }
        public int? Sale { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderOffer> OrderOffers { get; set; }
    }
}
