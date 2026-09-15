using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Pets;

public class Pet : BaseEntity<Guid>
{
    public string Name { get; private set; } = string.Empty;
    public int SpeciesId { get; private set; }
    public int? BreedId { get; private set; }
    public DateTime? DateOfBirth { get; private set; }
    public PetGender Gender { get; private set; }
    public PetSize? Size { get; private set; }
    public string? Colour { get; private set; }
    public string? Behaviour { get; private set; }
    public ActivityLevel? ActivityLevel { get; private set; }
    public string? Description { get; private set; }
    public PetStatus CurrentStatus { get; private set; }
    public Guid? CurrentOwnerUserId { get; private set; }
    public Guid? CurrentCaregiverUserId { get; private set; }
    public decimal? Latitude { get; private set; }
    public decimal? Longitude { get; private set; }
    public Guid CreatedBy { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    public Guid? DeletedBy { get; private set; }
    public long RowVersion { get; private set; }
}