using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Authorizations.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Authorizations.Queries.Models
{
    public class GetRoleListQuery : IRequest<CusResponse<List<GetRoleListResponse>>>
    {

    }
}
