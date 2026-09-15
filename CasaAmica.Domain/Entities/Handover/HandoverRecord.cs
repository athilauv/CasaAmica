using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Handover;

public class HandoverRecord : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public HandoverType HandoverType { get; private set; }
    public Guid FromUserId { get; private set; }
    public Guid ToUserId { get; private set; }
    public int? AppointmentId { get; private set; }
    public HandoverStatus Status { get; private set; }
    public DateTime InitiatedAt { get; private set; }
    public DateTime? CompletedAt { get; private set; }
    public Guid? CompletedBy { get; private set; }
    public string? Notes { get; private set; }
    public string IdempotencyKey { get; private set; } = string.Empty;
}