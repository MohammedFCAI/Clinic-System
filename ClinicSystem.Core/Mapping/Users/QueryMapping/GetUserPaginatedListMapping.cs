using ClinicSystem.Core.Features.Users.Queries.Responses;
using ClinicSystem.Data.Entities.Identities;

namespace ClinicSystem.Core.Mapping.Users
{
    public partial class UserProfile
    {
        public void GetUserPaginatedListMapping()
        {
            CreateMap<User, GetUserPaginatedListResponse>();
        }
    }
}
