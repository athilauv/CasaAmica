using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Notifications;

public class NotificationPreference : BaseEntity<long>
{
    public Guid UserId { get; private set; }
    public string NotificationType { get; private set; } = string.Empty;
    public bool InAppEnabled { get; private set; }
    public bool EmailEnabled { get; private set; }
    public bool SmsEnabled { get; private set; }
}