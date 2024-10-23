using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Appointments.Commands.Models
{
    public class DeleteAppointmentCommand : IRequest<CusResponse<string>>
    {
        public int id { get; set; }
        public DeleteAppointmentCommand(int Id)
        {
            id = Id;
        }
    }
}
