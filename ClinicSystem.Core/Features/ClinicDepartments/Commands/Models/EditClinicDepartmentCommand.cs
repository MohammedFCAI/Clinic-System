using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.ClinicDepartments.Commands.Models
{
    public class EditClinicDepartmentCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? Description { get; set; }
        public int ClinicId { get; set; }
    }
}
