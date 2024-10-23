using ClinicSystem.Core.Features.Doctors.Queries.Response;
using ClinicSystem.Core.Wappers;
using MediatR;

namespace ClinicSystem.Core.Features.Doctors.Queries.Models
{
    public class GetDoctorsPaginatedQuery : IRequest<PaginatedResult<GetDoctorsPaginatedResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string? Search { get; set; }
    }
}
