using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Medical;

public class Medication : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public string MedicationName { get; private set; } = string.Empty;
    public string? Dosage { get; private set; }
    public string? Frequency { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public string? Instructions { get; private set; }
}