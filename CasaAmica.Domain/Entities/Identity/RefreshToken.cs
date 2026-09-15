using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Identity;

public class RefreshToken : BaseEntity<int>
{
    public Guid UserId { get; private set; }
    public string Token { get; private set; } = string.Empty;
    public DateTime ExpiresAt { get; private set; }
    public bool IsRevoked { get; private set; }
}