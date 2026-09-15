using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Appointments;

public class Appointment : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public AppointmentType AppointmentType { get; private set; }
    public DateTime ScheduledStart { get; private set; }
    public DateTime ScheduledEnd { get; private set; }
    public string? Location { get; private set; }
    public AppointmentStatus Status { get; private set; }
    public Guid CreatedBy { get; private set; }
    public string? Notes { get; private set; }
}