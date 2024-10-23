using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Users.Commands.Models
{
    public class DeleteUserCommand : IRequest<CusResponse<string>>
    {
        public DeleteUserCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
