using ClinicSystem.Core.Features.Doctors.Queries.Response;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Doctors
{
    public partial class DoctorProfile
    {
        public void GetSingleDoctorMapping()
        {
            CreateMap<Doctor, GetSingleDoctorResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DoctorId));
        }
    }
}
