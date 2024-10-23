using ClinicSystem.Core.BasesCore;
using ClinicSystem.Data.Helpers;
using MediatR;

namespace ClinicSystem.Core.Features.Authorizations.Commands.Models
{
    public class EditUserRolesCommand : EditUserRolesRequest,
        IRequest<CusResponse<string>>
    {

    }
}
