using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Admin
    {
        public Admin()
        {
            AdminRoles = new HashSet<AdminRole>();
        }

        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid? UniqueId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Image { get; set; }
        public string? PhoneNumber { get; set; }
        public int? CityId { get; set; }
        public string? Adress { get; set; }
        public int? GenderId { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual City? City { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual ICollection<AdminRole> AdminRoles { get; set; }
    }
}
