using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Schedules.Commands.Models
{
    public class DeleteScheduleCommand : IRequest<CusResponse<string>>
    {

        public int Id { get; set; }
        public DeleteScheduleCommand(int ID)
        {
            Id = ID;
        }
    }
}
