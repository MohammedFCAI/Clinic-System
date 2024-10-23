using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Users.Commands.Models
{
    public class ChangeUserPasswordCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public string CurrentPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
    }
}
