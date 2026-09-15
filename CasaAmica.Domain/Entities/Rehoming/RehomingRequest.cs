using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Rehoming;

public class RehomingRequest : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public Guid OwnerUserId { get; private set; }
    public string ReasonType { get; private set; } = string.Empty;
    public string? ReasonDetails { get; private set; }
    public string Status { get; private set; } = string.Empty;
    public DateTime? ApprovedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }
}