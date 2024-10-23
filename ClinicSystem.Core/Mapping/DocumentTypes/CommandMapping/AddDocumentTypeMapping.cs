using ClinicSystem.Core.Features.DocumentTypes.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.DocumentTypes
{
    public partial class DocumentTypeProfile
    {
        public void AddDocumentTypeMapping()
        {
            CreateMap<AddDocumentTypeCommand, DocumentType>();
        }
    }
}
