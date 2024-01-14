namespace Infrastructure.Domain
{
    public class AudiTableEntity //BaseEntity, AuditedEntity
    {
        public int Id { get; set; }
        public int Creater { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastProcessUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
