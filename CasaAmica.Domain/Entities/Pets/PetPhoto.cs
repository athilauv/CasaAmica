using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Pets;

public class PetPhoto : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public int FileId { get; private set; }
    public bool IsPrimary { get; private set; }
    public int DisplayOrder { get; private set; }
}