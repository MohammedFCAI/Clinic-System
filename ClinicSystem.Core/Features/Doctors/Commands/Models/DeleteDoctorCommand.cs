using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Doctors.Commands.Models
{
    public class DeleteDoctorCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DeleteDoctorCommand(int id)
        {
            Id = id;
        }
    }
}
