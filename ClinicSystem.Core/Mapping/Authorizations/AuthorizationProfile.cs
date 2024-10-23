using AutoMapper;

namespace ClinicSystem.Core.Mapping.Authorizations
{
    public partial class AuthorizationProfile : Profile
    {
        public AuthorizationProfile()
        {
            GetRoleByIdMapping();
            GetRoleListMapping();
        }
    }
}
