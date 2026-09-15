using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Campaign;

public class Contribution : BaseEntity<int>
{
    public int CampaignId { get; private set; }
    public Guid? ContributorUserId { get; private set; }
    public decimal Amount { get; private set; }
    public DateTime ContributionDate { get; private set; }
    public ContributionStatus Status { get; private set; }
    public string? Reference { get; private set; }
}