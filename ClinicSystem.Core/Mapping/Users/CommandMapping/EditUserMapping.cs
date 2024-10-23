using ClinicSystem.Core.Features.Users.Commands.Models;
using ClinicSystem.Data.Entities.Identities;

namespace ClinicSystem.Core.Mapping.Users
{
    public partial class UserProfile
    {
        public void EditUserMapping()
        {
            CreateMap<EditUserCommand, User>();
        }
    }
}
