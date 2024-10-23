using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Clinics.Commands.Models
{
    public class EditClinicCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Details { get; set; }
    }
}
