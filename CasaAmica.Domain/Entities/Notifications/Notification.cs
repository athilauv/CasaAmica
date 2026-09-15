using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Notifications;

public class Notification : BaseEntity<int>
{
    public Guid UserId { get; private set; }
    public string NotificationType { get; private set; } = string.Empty;
    public string Title { get; private set; } = string.Empty;
    public string Message { get; private set; } = string.Empty;
    public string? ReferenceType { get; private set; }
    public string? ReferenceId { get; private set; }
    public NotificationStatus Status { get; private set; }
    public DateTime? ReadAt { get; private set; }
}