using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Rescue;

public class RescueCase : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public Guid RescuerUserId { get; private set; }
    public DateTime RescueDate { get; private set; }
    public string? RescueLocation { get; private set; }
    public string? Condition { get; private set; }
    public string? InitialMedicalNotes { get; private set; }
    public string Status { get; private set; } = string.Empty;
}