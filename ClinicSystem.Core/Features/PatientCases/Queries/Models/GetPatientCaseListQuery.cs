using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.PatientCases.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.PatientCases.Queries.Models
{
    public class GetPatientCaseListQuery : IRequest<CusResponse<List<GetPatientCaseListResponse>>>
    {


    }
}
