using ClinicSystem.Core.Features.Appointments.Queries.Responses;
using ClinicSystem.Core.Wappers;
using MediatR;

namespace ClinicSystem.Core.Features.Appointments.Queries.Models
{
    public class GetAppointmentPaginatedQuery : IRequest<PaginatedResult<GetAppointmentPaginatedResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }
        public string? StatusName { get; set; }
    }
}
