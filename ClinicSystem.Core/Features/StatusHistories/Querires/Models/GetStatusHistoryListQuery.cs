using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.StatusHistories.Querires.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.StatusHistories.Querires.Models
{
    public class GetStatusHistoryListQuery : IRequest<CusResponse<List<GetStatusHistoryListResponse>>>
    {

    }
}
