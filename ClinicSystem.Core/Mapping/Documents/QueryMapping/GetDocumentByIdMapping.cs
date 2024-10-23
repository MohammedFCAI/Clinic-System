using ClinicSystem.Core.Features.Documents.Queries.Responses;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Documents
{
    public partial class DocumentProfile
    {
        public void GetDocumentByIdMapping()
        {
            CreateMap<Document, GetSingleDocumentResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DocumentId))
                .ForMember(dest => dest.Doctor, opt => opt.MapFrom(src => src.Appointment.Doctor.FirstName + " " + src.Appointment.Doctor.LastName))
                .ForMember(dest => dest.DocumentType, opt => opt.MapFrom(src => src.DocumentType.TypeName));

        }
    }
}
