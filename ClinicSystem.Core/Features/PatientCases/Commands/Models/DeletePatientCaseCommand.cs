using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.PatientCases.Commands.Models
{
    public class DeletePatientCaseCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }
        public DeletePatientCaseCommand(int id)
        {
            Id = id;
        }
    }
}
