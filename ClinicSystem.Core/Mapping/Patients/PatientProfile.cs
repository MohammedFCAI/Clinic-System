using AutoMapper;

namespace ClinicSystem.Core.Mapping.Patients
{
    public partial class PatientProfile : Profile
    {

        public PatientProfile()
        {
            GetPatientListMapping();
            GetPatientByIdMapping();
            AddPatienMapping();
            EditPatientMapping();
        }
    }
}
