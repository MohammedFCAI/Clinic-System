using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Doctors.Queries.Response;
using MediatR;

namespace ClinicSystem.Core.Features.Doctors.Queries.Models
{
    public class GetDoctorsListQuery : IRequest<CusResponse<List<GetDoctorsListResponse>>>
    {

    }
}
