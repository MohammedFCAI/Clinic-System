using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Documents.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Documents.Queries.Models
{
    public class GetDocumentListQuery : IRequest<CusResponse<List<GetDocumentListResponse>>>
    {

    }
}
