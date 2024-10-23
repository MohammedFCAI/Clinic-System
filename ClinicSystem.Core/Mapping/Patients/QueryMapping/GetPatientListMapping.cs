using ClinicSystem.Core.Features.Patients.Queries.Responses;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Patients
{
    public partial class PatientProfile
    {
        public void GetPatientListMapping()
        {
            CreateMap<Patient, GetPatientsListResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.PatientId));
        }
    }
}
