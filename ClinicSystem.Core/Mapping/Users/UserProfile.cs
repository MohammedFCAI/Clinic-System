using AutoMapper;

namespace ClinicSystem.Core.Mapping.Users
{
    public partial class UserProfile : Profile
    {
        public UserProfile()
        {
            AddUserMapping();
            EditUserMapping();
            GetUserPaginatedListMapping();
            GetUserByIdMapping();
        }
    }
}
