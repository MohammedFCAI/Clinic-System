using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Patients.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Patients.Queries.Models
{
    public class GetPatientsListQuery : IRequest<CusResponse<List<GetPatientsListResponse>>>
    {

    }
}
