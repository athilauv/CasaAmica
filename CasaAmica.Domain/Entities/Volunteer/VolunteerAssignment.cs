using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Volunteer;

public class VolunteerAssignment : BaseEntity<int>
{
    public int VolunteerProfileId { get; private set; }
    public Guid? PetId { get; private set; }
    public VolunteerAssignmentRequestType RequestType { get; private set; }
    public DateTime AssignedDate { get; private set; }
    public VolunteerAssignmentStatus Status { get; private set; }
    public string? Notes { get; private set; }
    public DateTime? CompletedAt { get; private set; }
}