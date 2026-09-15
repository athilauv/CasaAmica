using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.LostFound;

public class LostPetReport : BaseEntity<int>
{
    public Guid? PetId { get; private set; }
    public Guid ReportedBy { get; private set; }
    public DateTime LostDate { get; private set; }
    public decimal? Latitude { get; private set; }
    public decimal? Longitude { get; private set; }
    public string? LocationDescription { get; private set; }
    public string? Description { get; private set; }
    public string? LastSeenInformation { get; private set; }
    public LostFoundStatus Status { get; private set; }
    public DateTime? ResolvedAt { get; private set; }
}