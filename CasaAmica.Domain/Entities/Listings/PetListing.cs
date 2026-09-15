using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Listings;

public class PetListing : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public ListingType ListingType { get; private set; }
    public Guid CreatedBy { get; private set; }
    public ListingStatus Status { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public DateTime? PublishedAt { get; private set; }
    public DateTime? ClosedAt { get; private set; }
    public long RowVersion { get; private set; }
}