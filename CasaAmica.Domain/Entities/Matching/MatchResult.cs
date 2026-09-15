using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Matching;

public class MatchResult : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public Guid UserId { get; private set; }
    public string MatchType { get; private set; } = string.Empty;
    public decimal Score { get; private set; }
    public string AlgorithmVersion { get; private set; } = string.Empty;
    public DateTime CalculatedAt { get; private set; }
    public DateTime? ExpiresAt { get; private set; }
}