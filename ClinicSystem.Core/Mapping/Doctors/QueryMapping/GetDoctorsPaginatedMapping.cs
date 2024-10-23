using ClinicSystem.Core.Features.Doctors.Queries.Response;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Doctors
{
    public partial class DoctorProfile
    {
        public void GetDoctorsPaginatedMapping()
        {
            CreateMap<Doctor, GetDoctorsPaginatedResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DoctorId));
        }
    }
}
