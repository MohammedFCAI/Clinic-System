using ClinicSystem.Core.Features.Authorizations.Queries.Responses;
using ClinicSystem.Data.Entities.Identities;

namespace ClinicSystem.Core.Mapping.Authorizations
{
    public partial class AuthorizationProfile
    {
        public void GetRoleByIdMapping()
        {
            CreateMap<Role, GetRoleByIdResponse>()
                .ForMember(dest => dest.roleName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
