using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Trust;

public class Report : BaseEntity<int>
{
    public Guid ReportedBy { get; private set; }
    public ReportTargetType TargetType { get; private set; }
    public string TargetId { get; private set; } = string.Empty;
    public string ReportType { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public ReportStatus Status { get; private set; }
    public Guid? ReviewedBy { get; private set; }
    public DateTime? ReviewedAt { get; private set; }
    public string? ResolutionNotes { get; private set; }
}