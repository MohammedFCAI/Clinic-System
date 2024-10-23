using ClinicSystem.Core.Features.Patients.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Patients
{
    public partial class PatientProfile
    {
        public void EditPatientMapping()
        {
            CreateMap<EditPatientCommand, Patient>()
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
