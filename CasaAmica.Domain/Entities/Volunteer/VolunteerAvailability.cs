using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Volunteer;

public class VolunteerAvailability : BaseEntity<long>
{
    public int VolunteerProfileId { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public string? Location { get; private set; }
}