using AutoMapper;

namespace ClinicSystem.Core.Mapping.Clinics
{
    public partial class ClinicProfile : Profile
    {
        public ClinicProfile()
        {
            AddClinicMapping();
            EditClinicMapping();
            GetClinicListMapping();

        }
    }
}
