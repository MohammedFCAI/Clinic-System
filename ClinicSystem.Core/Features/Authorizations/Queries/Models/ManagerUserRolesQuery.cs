using ClinicSystem.Core.BasesCore;
using ClinicSystem.Data.Helpers;
using MediatR;

namespace ClinicSystem.Core.Features.Authorizations.Queries.Models
{
    public class ManagerUserRolesQuery : IRequest<CusResponse<ManagerUserRolesResponse>>
    {
        public ManagerUserRolesQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
