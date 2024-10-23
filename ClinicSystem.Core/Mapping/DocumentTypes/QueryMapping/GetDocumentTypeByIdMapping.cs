using ClinicSystem.Core.Features.DocumentTypes.Queriers.Responses;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.DocumentTypes
{
    public partial class DocumentTypeProfile
    {
        public void GetDocumentTypeByIdMapping()
        {
            CreateMap<DocumentType, GetDocumentTypeByIdResponse>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DocumentTypeId));
        }
    }
}
