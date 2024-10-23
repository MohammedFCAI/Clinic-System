using ClinicSystem.Core.Features.ClinicDepartments.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.ClinicDepartments
{
    public partial class ClinicDepartmentProfile
    {
        public void AddClinicDepartmentMapping()
        {
            CreateMap<AddClinicDepartmentCommand, ClinicDepartment>();
        }
    }
}
