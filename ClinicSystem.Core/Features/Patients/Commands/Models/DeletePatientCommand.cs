using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Patients.Commands.Models
{
    public class DeletePatientCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DeletePatientCommand(int id)
        {
            Id = id;
        }
    }
}
