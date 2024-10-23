using ClinicSystem.Core.Features.Documents.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Documents
{
    public partial class DocumentProfile
    {
        public void AddDocumentMapping()
        {
            CreateMap<AddDocumentCommand, Document>();

        }
    }
}
