using ClinicSystem.Core.Features.Clinics.Queries.Response;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Clinics
{
    public partial class ClinicProfile
    {
        public void GetClinicListMapping()
        {

            CreateMap<Clinic, GetClinicListResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ClinicId));
        }
    }
}
