using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.ClinicDepartments.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.ClinicDepartments.Queries.Models
{
    public class GetClinicDepartmentListQuery : IRequest<CusResponse<List<GetClinicDepartmentResponse>>>
    {

    }
}
