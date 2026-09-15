using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Pets;

public class File : BaseEntity<int>
{
    public string FileName { get; private set; } = string.Empty;
    public string StorageProvider { get; private set; } = string.Empty;
    public string StorageKey { get; private set; } = string.Empty;
    public string ContentType { get; private set; } = string.Empty;
    public long? FileSize { get; private set; }
    public Guid UploadedBy { get; private set; }
    public DateTime UploadedAt { get; private set; }
}