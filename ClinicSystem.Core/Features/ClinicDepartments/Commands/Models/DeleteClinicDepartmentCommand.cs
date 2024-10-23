using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.ClinicDepartments.Commands.Models
{
    public class DeleteClinicDepartmentCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DeleteClinicDepartmentCommand(int id)
        {
            Id = id;
        }
    }
}
