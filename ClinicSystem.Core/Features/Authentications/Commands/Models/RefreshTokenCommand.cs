using ClinicSystem.Core.BasesCore;
using ClinicSystem.Data.Helpers;
using MediatR;

namespace ClinicSystem.Core.Features.Authentications.Commands.Models
{
    public class RefreshTokenCommand : IRequest<CusResponse<JwtAuthResponse>>
    {
        public string AccessToken { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
    }
}
