using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.StatusHistories.Commands.Models
{
    public class EditStatusHistoryCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public string? details { get; set; }
        public int AppointmentId { get; set; }
        public int AppointmentStatusID { get; set; }
    }
}
