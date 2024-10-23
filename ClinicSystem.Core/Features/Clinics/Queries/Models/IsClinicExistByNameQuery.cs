using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Clinics.Queries.Models
{
    public class IsClinicExistByNameQuery : IRequest<CusResponse<string>>
    {
        public string ClinicName { get; set; } = null!;
    }
}
