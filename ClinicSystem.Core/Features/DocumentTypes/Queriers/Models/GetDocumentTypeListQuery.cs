using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.DocumentTypes.Queriers.Response;
using MediatR;

namespace ClinicSystem.Core.Features.DocumentTypes.Queriers.Models
{
    public class GetDocumentTypeListQuery : IRequest<CusResponse<List<GetDocumentTypeListResponse>>>
    {

    }
}
