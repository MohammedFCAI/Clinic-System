using ClinicSystem.Core.Features.Doctors.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Doctors
{
    public partial class DoctorProfile
    {
        public void EditDoctorMapping()
        {
            CreateMap<EditDoctorCommand, Doctor>().ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
