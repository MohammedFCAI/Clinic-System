using ClinicSystem.Core.Features.Documents.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Documents
{
    public partial class DocumentProfile
    {
        public void EditDocumentMapping()
        {
            CreateMap<EditDocumentCommand, Document>().ForMember(dest => dest.DocumentId,
                opt => opt.MapFrom(src => src.Id));

        }
    }
}
