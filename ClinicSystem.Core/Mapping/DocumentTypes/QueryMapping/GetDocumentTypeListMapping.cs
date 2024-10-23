using ClinicSystem.Core.Features.DocumentTypes.Queriers.Response;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.DocumentTypes
{
    public partial class DocumentTypeProfile
    {
        public void GetDocumentTypeListMapping()
        {
            CreateMap<DocumentType, GetDocumentTypeListResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DocumentTypeId));
        }
    }
}
