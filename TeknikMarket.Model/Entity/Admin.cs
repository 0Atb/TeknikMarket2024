using Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace TeknikMarket.Model.Entity
{
    public partial class Admin:AudiTableEntity,IBaseDomain
    {
        public Admin()
        {
            AdminRoles = new HashSet<AdminRole>();
        }

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

        public virtual City? City { get; set; }
        public virtual Gender? Gender { get; set; }
        public virtual ICollection<AdminRole> AdminRoles { get; set; }
    }
}
