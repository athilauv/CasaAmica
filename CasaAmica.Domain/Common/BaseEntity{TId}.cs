namespace CasaAmica.Domain.Common;

public abstract class BaseEntity<TId> : BaseEntity
{
    public TId Id { get; protected set; } = default!;
}