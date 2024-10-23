using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.EmployeeSchedulesFile.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.EmployeeSchedulesFile.Queries.Models
{
    public class GetEmployeeScheduleByIdQuery : IRequest<CusResponse<GetSingleEmployeeScheduleResponse>>
    {
        public int Id { get; set; }
        public GetEmployeeScheduleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
