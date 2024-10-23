using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Patients.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Patients.Queries.Models
{
    public class GetPatientByIdQuery : IRequest<CusResponse<GetPatientByIdResponse>>
    {
        public int Id { get; set; }

        public GetPatientByIdQuery(int id)
        {
            Id = id;
        }
    }
}
