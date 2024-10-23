using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Appointments.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Appointments.Queries.Models
{
    public class GetAppointmentListQuery : IRequest<CusResponse<List<GetAppointmentListResponse>>>
    {

    }
}
