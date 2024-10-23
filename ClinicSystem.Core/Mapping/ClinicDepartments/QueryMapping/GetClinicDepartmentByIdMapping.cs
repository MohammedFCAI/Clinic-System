using ClinicSystem.Core.Features.ClinicDepartments.Queries.Responses;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.ClinicDepartments
{
    public partial class ClinicDepartmentProfile
    {
        public void GetClinicDepartmentByIdMapping()
        {

            CreateMap<ClinicDepartment, GetClinicDepartmentResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.ClinicName, opt => opt.MapFrom(src => src.Clinic.Name));
        }
    }
}
