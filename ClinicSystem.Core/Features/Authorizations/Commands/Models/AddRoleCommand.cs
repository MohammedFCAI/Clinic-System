using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Authorizations.Commands.Models
{
    public class AddRoleCommand : IRequest<CusResponse<string>>
    {
        public string roleName { get; set; } = null!;
    }
}
