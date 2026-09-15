using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Pets;

public class PetLifecycleEvent : BaseEntity<long>
{
    public Guid PetId { get; private set; }
    public string EventType { get; private set; } = string.Empty;
    public PetStatus? FromStatus { get; private set; }
    public PetStatus? ToStatus { get; private set; }
    public Guid PerformedBy { get; private set; }
    public DateTime EventDate { get; private set; }
    public string? ReferenceType { get; private set; }
    public string? ReferenceId { get; private set; }
    public string? Notes { get; private set; }
}