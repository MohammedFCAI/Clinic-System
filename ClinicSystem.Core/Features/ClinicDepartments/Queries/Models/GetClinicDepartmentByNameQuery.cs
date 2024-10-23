using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.ClinicDepartments.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.ClinicDepartments.Queries.Models
{
    public class GetClinicDepartmentByNameQuery : IRequest<CusResponse<GetClinicDepartmentResponse>>
    {
        public string DepartmentName { get; set; } = null!;
        public GetClinicDepartmentByNameQuery(string departmentName)
        {
            DepartmentName = departmentName;
        }
    }
}
