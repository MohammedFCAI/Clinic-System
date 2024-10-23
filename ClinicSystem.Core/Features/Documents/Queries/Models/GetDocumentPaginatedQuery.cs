using ClinicSystem.Core.Features.Documents.Queries.Responses;
using ClinicSystem.Core.Wappers;
using MediatR;

namespace ClinicSystem.Core.Features.Documents.Queries.Models
{
    public class GetDocumentPaginatedQuery : IRequest<PaginatedResult<GetDocumentPaginatedResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public string? DoctorName { get; set; }
        public string? TypeName { get; set; }
    }
}
