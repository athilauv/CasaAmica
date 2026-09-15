using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Care;

public class CaregiverAvailability : BaseEntity<long>
{
    public Guid UserId { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public string? Location { get; private set; }
    public int? MaxPets { get; private set; }
    public string Status { get; private set; } = string.Empty;
}