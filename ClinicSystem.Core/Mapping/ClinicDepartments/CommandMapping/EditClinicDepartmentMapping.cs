using ClinicSystem.Core.Features.ClinicDepartments.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.ClinicDepartments
{
    public partial class ClinicDepartmentProfile
    {
        public void EditClinicDepartmentMapping()
        {
            CreateMap<EditClinicDepartmentCommand, ClinicDepartment>()
               .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
