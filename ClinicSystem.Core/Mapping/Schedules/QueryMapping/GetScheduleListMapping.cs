using ClinicSystem.Core.Features.Schedules.Queries.Responses;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Schedules
{
    public partial class ScheduleProfile
    {
        public void GetScheduleListMapping()
        {
            CreateMap<Schedule, GetScheduleListResponse>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ScheduleId))
               .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.EmployeeSchedules.Doctor.FirstName + " " + src.EmployeeSchedules.Doctor.LastName))
               .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.EmployeeSchedules.ClinicDepartment.DepartmentName));

        }
    }
}
