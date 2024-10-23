using ClinicSystem.Core.Features.Patients.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Patients
{
    public partial class PatientProfile
    {
        public void AddPatienMapping()
        {
            CreateMap<AddPatientCommand, Patient>();
        }
    }
}
