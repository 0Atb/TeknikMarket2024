using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class AdminRole
    {
        public int Id { get; set; }
        public int? AdminId { get; set; }
        public int? RoleId { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Admin? Admin { get; set; }
        public virtual Role? Role { get; set; }
    }
}
