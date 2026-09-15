using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Identity;

public class User : BaseEntity<Guid>
{
    public string Email { get; private set; } = string.Empty;
    public string PasswordHash { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }
    public bool IsVerified { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    public long RowVersion { get; private set; }
}