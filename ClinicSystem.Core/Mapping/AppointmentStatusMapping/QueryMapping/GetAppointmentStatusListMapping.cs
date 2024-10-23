using ClinicSystem.Core.Features.AppointmentStatuses.Queries.Responses;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.AppointmentStatusMapping
{
    public partial class AppointmentStatusProfile
    {
        public void GetAppointmentStatusListMapping()
        {
            CreateMap<AppointmentStatus, GetAppointmentStatusListResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AppointmentStatusId));
        }
    }
}
