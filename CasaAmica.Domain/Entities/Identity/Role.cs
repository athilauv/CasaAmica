using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Identity;

public class Role : BaseEntity<int>
{
    public string Name { get; private set; } = string.Empty;
    public string? Description { get; private set; }
}