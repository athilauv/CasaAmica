using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Handover;

public class HandoverConfirmation : BaseEntity<int>
{
    public int HandoverId { get; private set; }
    public Guid UserId { get; private set; }
    public string ConfirmationType { get; private set; } = string.Empty;
    public DateTime ConfirmedAt { get; private set; }
}