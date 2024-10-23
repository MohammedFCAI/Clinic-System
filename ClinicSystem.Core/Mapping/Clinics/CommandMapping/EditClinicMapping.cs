using ClinicSystem.Core.Features.Clinics.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Clinics
{
    public partial class ClinicProfile
    {
        public void EditClinicMapping()
        {
            CreateMap<EditClinicCommand, Clinic>().ForMember(dest => dest.ClinicId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
