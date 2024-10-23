using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.EmployeeSchedulesFile.Commands.Models
{
    public class DeleteEmployeeScheduleCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DeleteEmployeeScheduleCommand(int id)
        {
            Id = id;
        }
    }
}
