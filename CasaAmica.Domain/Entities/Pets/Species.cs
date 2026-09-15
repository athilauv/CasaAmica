using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Pets;

public class Species : BaseEntity<int>
{
    public string Name { get; private set; } = string.Empty;
}