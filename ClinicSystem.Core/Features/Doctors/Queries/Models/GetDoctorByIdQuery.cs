using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Doctors.Queries.Response;
using MediatR;

namespace ClinicSystem.Core.Features.Doctors.Queries.Models
{
    public class GetDoctorByIdQuery : IRequest<CusResponse<GetSingleDoctorResponse>>
    {
        public int Id { get; set; }
        public GetDoctorByIdQuery(int id)
        {
            Id = id;
        }
    }
}
