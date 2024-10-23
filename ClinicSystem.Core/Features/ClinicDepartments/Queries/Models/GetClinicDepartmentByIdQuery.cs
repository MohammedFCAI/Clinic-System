using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.ClinicDepartments.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.ClinicDepartments.Queries.Models
{
    public class GetClinicDepartmentByIdQuery : IRequest<CusResponse<GetClinicDepartmentResponse>>
    {

        public int Id { get; set; }

        public GetClinicDepartmentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
