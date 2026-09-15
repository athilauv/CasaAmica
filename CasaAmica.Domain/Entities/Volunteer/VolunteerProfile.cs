using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Volunteer;

public class VolunteerProfile : BaseEntity<int>
{
    public Guid UserId { get; private set; }
    public string? Bio { get; private set; }
    public string? VerificationLevel { get; private set; }
    public bool IsAvailable { get; private set; }
}