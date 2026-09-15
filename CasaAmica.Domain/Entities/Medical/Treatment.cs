using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Medical;

public class Treatment : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public string TreatmentName { get; private set; } = string.Empty;
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public string? Description { get; private set; }
    public string? Notes { get; private set; }
}