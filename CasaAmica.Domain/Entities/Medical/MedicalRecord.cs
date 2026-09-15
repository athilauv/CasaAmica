using CasaAmica.Domain.Common;
using CasaAmica.Domain.Enums;

namespace CasaAmica.Domain.Entities.Medical;

public class MedicalRecord : BaseEntity<int>
{
    public Guid PetId { get; private set; }
    public MedicalRecordType RecordType { get; private set; }
    public DateTime RecordDate { get; private set; }
    public string? Description { get; private set; }
    public string? VeterinarianName { get; private set; }
    public string? ClinicName { get; private set; }
    public string? Notes { get; private set; }
    public Guid CreatedBy { get; private set; }
}