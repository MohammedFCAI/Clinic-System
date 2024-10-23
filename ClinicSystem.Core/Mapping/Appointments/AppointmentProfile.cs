using AutoMapper;

namespace ClinicSystem.Core.Mapping.Appointments
{
    public partial class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            AddAppointmentMapping();
            EditAppointmentMapping();
            GetAppointmentListMapping();
            GetAppointmentByIdMapping();
        }
    }
}
