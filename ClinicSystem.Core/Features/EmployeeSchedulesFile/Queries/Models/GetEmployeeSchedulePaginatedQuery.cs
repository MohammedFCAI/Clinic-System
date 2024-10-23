using ClinicSystem.Core.Features.EmployeeSchedulesFile.Queries.Responses;
using ClinicSystem.Core.Wappers;
using MediatR;

namespace ClinicSystem.Core.Features.EmployeeSchedulesFile.Queries.Models
{
    public class GetEmployeeSchedulePaginatedQuery : IRequest<PaginatedResult<GetEmployeeSchedulePaginatedResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool IsActive { get; set; }
    }
}
