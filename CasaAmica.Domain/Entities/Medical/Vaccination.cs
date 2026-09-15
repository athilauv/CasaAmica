using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Medical;

public class Vaccination : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public string VaccineName { get; private set; } = string.Empty;
    public DateTime AdministeredDate { get; private set; }
    public DateTime? NextDueDate { get; private set; }
    public string? VeterinarianName { get; private set; }
    public string? Notes { get; private set; }
}