using ClinicSystem.Core.Features.EmployeeSchedulesFile.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.EmloyeeSchedulesMapping
{
    public partial class EmployeeScheduleProfile
    {
        public void AddEmployeeScheduleMapping()
        {
            CreateMap<AddEmployeeScheduleCommand, EmployeeSchedules>()
            .ForMember(dest => dest.clinicDepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
            .ForMember(dest => dest.TimeFrom, opt => opt.MapFrom(src => new TimeOnly(src.TimeFrom.Hour, src.TimeFrom.Minute)))
            .ForMember(dest => dest.TimeTo, opt => opt.MapFrom(src => new TimeOnly(src.TimeTo.Hour, src.TimeTo.Minute)));
        }
    }
}
