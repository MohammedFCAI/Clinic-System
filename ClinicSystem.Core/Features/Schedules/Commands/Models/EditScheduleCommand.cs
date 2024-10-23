using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Schedules.Commands.Models
{
    public class EditScheduleCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public int EmployeeSchedulesId { get; set; }
    }
}
