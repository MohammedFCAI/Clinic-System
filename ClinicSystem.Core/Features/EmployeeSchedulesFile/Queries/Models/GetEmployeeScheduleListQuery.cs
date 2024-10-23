using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.EmployeeSchedulesFile.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.EmployeeSchedulesFile.Queries.Models
{
    public class GetEmployeeScheduleListQuery : IRequest<CusResponse<List<GetEmployeeScheduleListResponse>>>
    {

    }
}
