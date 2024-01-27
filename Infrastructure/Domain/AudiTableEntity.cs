namespace Infrastructure.Domain
{
    public class AudiTableEntity //BaseEntity, AuditedEntity
    {
        public int Id { get; set; }
        public int? Creater { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastProcessUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }


        //public int Id { get; set; }
        //public Nullable<int> Creater { get; set; }
        //public Nullable<DateTime> CreatedDate { get; set; }
        //public Nullable<int> LastProcessUser { get; set; }
        //public Nullable<DateTime> UpdatedDate { get; set; }
        //public Nullable<bool> IsDeleted { get; set; }
    }
}
