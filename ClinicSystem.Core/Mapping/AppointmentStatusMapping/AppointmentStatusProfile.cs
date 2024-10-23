using AutoMapper;

namespace ClinicSystem.Core.Mapping.AppointmentStatusMapping
{
    public partial class AppointmentStatusProfile : Profile
    {

        public AppointmentStatusProfile()
        {
            GetAppointmentStatusListMapping();
            GetSingleAppointmentStatusMapping();
        }
    }
}
