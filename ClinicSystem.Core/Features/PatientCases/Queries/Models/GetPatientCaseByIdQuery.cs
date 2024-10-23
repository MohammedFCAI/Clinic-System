using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.PatientCases.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.PatientCases.Queries.Models
{
    public class GetPatientCaseByIdQuery : IRequest<CusResponse<GetSinglePatientCaseResponse>>
    {
        public int Id { get; set; }
        public GetPatientCaseByIdQuery(int id)
        {
            Id = id;
        }
    }
}
