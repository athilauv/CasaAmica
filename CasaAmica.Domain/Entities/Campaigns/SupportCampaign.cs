using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Campaign;

public class SupportCampaign : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public Guid CreatedBy { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public decimal TargetAmount { get; private set; }
    public decimal CollectedAmount { get; private set; }
    public SupportCampaignStatus Status { get; private set; }
    public DateTime? StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
}