using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.AppointmentStatuses.Queries.Responses;
using MediatR;

namespace ClinicSystem.Core.Features.AppointmentStatuses.Queries.Models
{
    public class GetAppointmentStatusLByIdQuery : IRequest<CusResponse<GetSingleAppointmentStatusResponse>>
    {
        public int Id { get; set; }
        public GetAppointmentStatusLByIdQuery(int id)
        {
            Id = id;
        }
    }
}
