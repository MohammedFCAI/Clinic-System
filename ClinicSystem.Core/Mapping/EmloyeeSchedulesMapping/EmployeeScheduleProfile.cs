using AutoMapper;

namespace ClinicSystem.Core.Mapping.EmloyeeSchedulesMapping
{
    public partial class EmployeeScheduleProfile : Profile
    {
        public EmployeeScheduleProfile()
        {
            AddEmployeeScheduleMapping();
            EditEmployeeScheduleMapping();
            GetEmployeeScheduleListMapping();
            GetEmployeeScheduleByIdMapping();
        }
    }
}
