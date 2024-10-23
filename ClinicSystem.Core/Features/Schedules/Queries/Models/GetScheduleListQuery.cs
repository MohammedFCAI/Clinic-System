using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Schedules.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Schedules.Queries.Models
{
    public class GetScheduleListQuery : IRequest<CusResponse<List<GetScheduleListResponse>>>
    {

    }
}
