using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Clinics.Queries.Response;
using MediatR;

namespace ClinicSystem.Core.Features.Clinics.Queries.Models
{
    public class GetClinicListQuery : IRequest<CusResponse<List<GetClinicListResponse>>>
    {

    }
}
