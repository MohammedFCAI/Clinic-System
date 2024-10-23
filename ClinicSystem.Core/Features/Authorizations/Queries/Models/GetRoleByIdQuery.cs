using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Authorizations.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Authorizations.Queries.Models
{
    public class GetRoleByIdQuery : IRequest<CusResponse<GetRoleByIdResponse>>
    {
        public int Id { get; set; }

        public GetRoleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
