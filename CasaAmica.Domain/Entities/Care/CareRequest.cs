using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Care;

public class CareRequest : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public Guid RequesterUserId { get; private set; }
    public CareType CareType { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public string? PreferredLocation { get; private set; }
    public string? Requirements { get; private set; }
    public string? FeedingInstructions { get; private set; }
    public string? MedicationInstructions { get; private set; }
    public string? DailyRoutine { get; private set; }
    public string? SpecialRequirements { get; private set; }
    public CareRequestStatus Status { get; private set; }
    public long RowVersion { get; private set; }
}