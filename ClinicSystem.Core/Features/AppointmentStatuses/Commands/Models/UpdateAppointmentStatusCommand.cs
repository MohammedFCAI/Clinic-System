using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.AppointmentStatuses.Commands.Models
{
    public class UpdateAppointmentStatusCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public string statusName { get; set; } = null!;
    }
}
