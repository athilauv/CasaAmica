using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Matching;

public class MatchingPreference : BaseEntity<int>
{
    public Guid UserId { get; private set; }
    public int? SpeciesId { get; private set; }
    public int? BreedId { get; private set; }
    public int? PreferredAgeMin { get; private set; }
    public int? PreferredAgeMax { get; private set; }
    public PetSize? PreferredSize { get; private set; }
    public ActivityLevel? PreferredActivityLevel { get; private set; }
    public string? PreferredLocation { get; private set; }
    public decimal? Latitude { get; private set; }
    public decimal? Longitude { get; private set; }
    public decimal? SearchRadiusKm { get; private set; }
    public bool? HasPetExperience { get; private set; }
    public string? LivingEnvironment { get; private set; }
}