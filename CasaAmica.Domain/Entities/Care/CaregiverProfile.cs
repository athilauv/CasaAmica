using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Care;

public class CaregiverProfile : BaseEntity<int>
{
    public Guid UserId { get; private set; }
    public bool CanFoster { get; private set; }
    public bool CanTemporaryCare { get; private set; }
    public string? ExperienceDescription { get; private set; }
    public int? MaxPets { get; private set; }
    public string? VerificationLevel { get; private set; }
}