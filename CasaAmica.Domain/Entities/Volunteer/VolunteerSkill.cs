using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Volunteer;

public class VolunteerSkill : BaseEntity<long>
{
    public int VolunteerProfileId { get; private set; }
    public VolunteerSkillType SkillType { get; private set; }
    public string? ExperienceLevel { get; private set; }
}