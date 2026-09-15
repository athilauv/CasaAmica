using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Identity;

public class UserRole : BaseEntity
{
    public Guid UserId { get; private set; }
    public int RoleId { get; private set; }
}