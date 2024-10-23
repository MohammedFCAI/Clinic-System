using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.AppointmentStatuses.Commands.Models
{
    public class AddAppointmentStatusCommand : IRequest<CusResponse<string>>
    {
        public string StatusName { get; set; } = null!;
    }
}
