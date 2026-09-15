using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Pets;

public class Breed : BaseEntity<int>
{
    public int SpeciesId { get; private set; }
    public string Name { get; private set; } = string.Empty;
}