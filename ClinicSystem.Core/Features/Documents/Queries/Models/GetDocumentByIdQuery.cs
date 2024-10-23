using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Documents.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.Documents.Queries.Models
{
    public class GetDocumentByIdQuery : IRequest<CusResponse<GetSingleDocumentResponse>>
    {

        public int Id { get; set; }
        public GetDocumentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
