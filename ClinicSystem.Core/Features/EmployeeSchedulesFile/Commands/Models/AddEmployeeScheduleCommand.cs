using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.EmployeeSchedulesFile.Commands.Models
{
    public class AddEmployeeScheduleCommand : IRequest<CusResponse<string>>
    {
        public int DoctorId { get; set; }
        public int DepartmentId { get; set; }

        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public bool IsActive { get; set; }

    }
}
