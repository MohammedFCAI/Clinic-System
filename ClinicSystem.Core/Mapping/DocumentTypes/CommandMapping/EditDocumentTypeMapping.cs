using ClinicSystem.Core.Features.DocumentTypes.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.DocumentTypes
{
    public partial class DocumentTypeProfile
    {
        public void EditDocumentTypeMapping()
        {
            CreateMap<EditDocumentTypeCommand, DocumentType>().ForMember(dest => dest.DocumentTypeId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
