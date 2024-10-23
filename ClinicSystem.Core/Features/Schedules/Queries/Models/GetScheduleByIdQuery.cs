using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Schedules.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Schedules.Queries.Models
{
    public class GetScheduleByIdQuery : IRequest<CusResponse<GetScheduleByIdResponse>>
    {
        public int Id { get; set; }
        public GetScheduleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
