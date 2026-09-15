using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Medical;

public class Allergy : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public string Allergen { get; private set; } = string.Empty;
    public string? Severity { get; private set; }
    public string? Reaction { get; private set; }
    public string? Notes { get; private set; }
}