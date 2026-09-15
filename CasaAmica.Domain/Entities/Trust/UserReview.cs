using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Trust;

public class UserReview : BaseEntity<int>
{
    public Guid ReviewerUserId { get; private set; }
    public Guid ReviewedUserId { get; private set; }
    public Guid? PetId { get; private set; }
    public string RelatedTransactionType { get; private set; } = string.Empty;
    public string RelatedTransactionId { get; private set; } = string.Empty;
    public int Rating { get; private set; }
    public string? Comment { get; private set; }
}