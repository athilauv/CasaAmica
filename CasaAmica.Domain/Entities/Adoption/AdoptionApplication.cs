using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Adoption;

public class AdoptionApplication : BaseEntity<int>
{
    public int PetListingId { get; private set; }
    public Guid ApplicantUserId { get; private set; }
    public ApplicationStatus Status { get; private set; }
    public string? Message { get; private set; }
    public DateTime SubmittedAt { get; private set; }
    public DateTime? ReviewedAt { get; private set; }
    public Guid? ReviewedBy { get; private set; }
    public string? DecisionReason { get; private set; }
    public long RowVersion { get; private set; }
}