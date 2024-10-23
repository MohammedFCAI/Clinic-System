using ClinicSystem.Core.Features.PatientCases.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.PatientCases
{
    public partial class PatientCaseProfile
    {
        public void EditPatientCaseMapping()
        {
            CreateMap<EditPatientCaseCommand, PatientCase>()
                .ForMember(dest => dest.PatientCaseId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => new DateOnly(src.StartTime.Year, src.StartTime.Month, src.StartTime.Day)))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime.HasValue ?
                new DateOnly(src.EndTime.Value.Year, src.EndTime.Value.Month, src.EndTime.Value.Day)
                : (DateOnly?)null));
        }
    }
}
