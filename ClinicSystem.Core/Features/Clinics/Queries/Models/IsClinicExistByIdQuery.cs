using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Clinics.Queries.Models
{
    public class IsClinicExistByIdQuery : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }

        public IsClinicExistByIdQuery(int id)
        {
            Id = id;
        }
    }
}
