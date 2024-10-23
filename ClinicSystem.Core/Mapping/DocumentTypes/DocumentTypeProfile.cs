using AutoMapper;

namespace ClinicSystem.Core.Mapping.DocumentTypes
{
    public partial class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            AddDocumentTypeMapping();
            EditDocumentTypeMapping();
            GetDocumentTypeListMapping();
            GetDocumentTypeByIdMapping();
        }
    }
}
