using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Documents.Commands.Models
{
    public class DeleteDocumentCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }

        public DeleteDocumentCommand(int id)
        {
            Id = id;
        }
    }
}
