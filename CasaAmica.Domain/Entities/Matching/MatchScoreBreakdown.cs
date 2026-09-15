using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Matching;

public class MatchScoreBreakdown : BaseEntity<long>
{
    public int MatchResultId { get; private set; }
    public string Factor { get; private set; } = string.Empty;
    public decimal Weight { get; private set; }
    public decimal RawScore { get; private set; }
    public decimal WeightedScore { get; private set; }
    public string? Explanation { get; private set; }
}