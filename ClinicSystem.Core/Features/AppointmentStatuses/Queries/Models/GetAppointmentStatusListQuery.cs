using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.AppointmentStatuses.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.AppointmentStatuses.Queries.Models
{
    public class GetAppointmentStatusListQuery : IRequest<CusResponse<List<GetAppointmentStatusListResponse>>>
    {

    }
}
