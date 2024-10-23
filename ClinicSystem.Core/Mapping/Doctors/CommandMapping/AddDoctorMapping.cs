using ClinicSystem.Core.Features.Doctors.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Doctors
{
    public partial class DoctorProfile
    {

        public void AddDoctorMapping()
        {
            CreateMap<AddDoctorCommand, Doctor>();
        }
    }
}
