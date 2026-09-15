using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Pets;

public class PetOwnershipHistory : BaseEntity<long>
{
    public Guid PetId { get; private set; }
    public Guid OwnerUserId { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public string OwnershipType { get; private set; } = string.Empty;
    public string? Reason { get; private set; }
    public string? ReferenceType { get; private set; }
    public string? ReferenceId { get; private set; }
}