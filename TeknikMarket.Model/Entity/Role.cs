using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Role
    {
        public Role()
        {
            AdminRoles = new HashSet<AdminRole>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string? RoleName { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<AdminRole> AdminRoles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
