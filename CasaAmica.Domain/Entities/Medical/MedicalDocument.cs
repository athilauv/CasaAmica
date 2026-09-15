using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Medical;

public class MedicalDocument : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public int FileId { get; private set; }
    public string DocumentType { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public DateTime UploadedAt { get; private set; }
}