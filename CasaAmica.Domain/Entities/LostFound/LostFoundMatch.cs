using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.LostFound;

public class LostFoundMatch : BaseEntity<int>
{
    public int LostReportId { get; private set; }
    public int FoundReportId { get; private set; }
    public decimal Score { get; private set; }
    public string AlgorithmVersion { get; private set; } = string.Empty;
    public string Status { get; private set; } = string.Empty;
}