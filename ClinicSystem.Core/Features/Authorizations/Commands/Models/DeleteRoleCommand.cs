using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Authorizations.Commands.Models
{
    public class DeleteRoleCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }

        public DeleteRoleCommand(int id)
        {
            Id = id;
        }
    }
}
