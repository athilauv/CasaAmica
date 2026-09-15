using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Identity;

public class UserVerification : BaseEntity<int>
{
    public Guid UserId { get; private set; }

    public VerificationType VerificationType { get; private set; }

    public UserVerificationStatus Status { get; private set; }

    public DateTime? VerifiedAt { get; private set; }

    public Guid? VerifiedBy { get; private set; }

    public int? DocumentFileId { get; private set; }

    public string? Notes { get; private set; }
}