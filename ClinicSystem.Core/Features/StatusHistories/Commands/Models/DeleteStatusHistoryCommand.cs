using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.StatusHistories.Commands.Models
{
    public class DeleteStatusHistoryCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DeleteStatusHistoryCommand(int id)
        {
            Id = id;
        }
    }
}
