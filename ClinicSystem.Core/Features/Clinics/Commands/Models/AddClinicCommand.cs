using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Clinics.Commands.Models
{
    public class AddClinicCommand : IRequest<CusResponse<string>>
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Details { get; set; }
    }
}
