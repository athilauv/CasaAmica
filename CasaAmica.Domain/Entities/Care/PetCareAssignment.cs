using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Care;

public class PetCareAssignment : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public Guid CaregiverUserId { get; private set; }
    public int CareRequestId { get; private set; }
    public CareType CareType { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }
    public CareAssignmentStatus Status { get; private set; }
    public Guid AssignedBy { get; private set; }
    public string? Notes { get; private set; }
    public DateTime? CompletedAt { get; private set; }
}