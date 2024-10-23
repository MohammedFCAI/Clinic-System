using AutoMapper;

namespace ClinicSystem.Core.Mapping.Documents
{
    public partial class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            AddDocumentMapping();
            EditDocumentMapping();
            GetDocumentListMapping();
            GetDocumentByIdMapping();
        }
    }
}
