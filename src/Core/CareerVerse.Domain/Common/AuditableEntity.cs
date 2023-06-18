namespace CareerVerse.Domain.Common
{
    public abstract class AuditableEntityBase<TId> : EntityBase<TId>, IAuditableEntity, ISoftDeletable
    {
        public virtual DateTime CreatedAt { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? ModifiedAt { get; set; }
        public virtual string? ModifiedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public virtual string? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
