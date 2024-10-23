using ClinicSystem.Core.BasesCore;
using ClinicSystem.Data.Helpers;
using MediatR;

namespace ClinicSystem.Core.Features.Authentications.Commands.Models
{
    public class SignInCommand : IRequest<CusResponse<JwtAuthResponse>>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
