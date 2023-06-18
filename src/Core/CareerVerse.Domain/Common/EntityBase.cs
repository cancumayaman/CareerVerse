namespace CareerVerse.Domain.Common
{
    public abstract class EntityBase<TId> : IEntity<TId>
    {
        public virtual TId Id { get; set; }
    }
}
