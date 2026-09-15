using CasaAmica.Domain.Common;

namespace CasaAmica.Domain.Entities.Users;

public class UserProfile : BaseEntity<int>
{
    public Guid UserId { get; private set; }
    public string FirstName { get; private set; } = string.Empty;
    public string? LastName { get; private set; }
    public string? Phone { get; private set; }
    public DateTime? DateOfBirth { get; private set; }
    public string? Address { get; private set; }
    public string? City { get; private set; }
    public string? Country { get; private set; }
    public decimal? Latitude { get; private set; }
    public decimal? Longitude { get; private set; }
    public string? Bio { get; private set; }
    public string? ProfilePhotoUrl { get; private set; }
}