using ClinicSystem.Core.BasesCore;
using MediatR;

namespace ClinicSystem.Core.Features.Clinics.Commands.Models
{
    public class DeleteClinicCommand : IRequest<CusResponse<string>>
    {
        public int Id { get; set; }

        public DeleteClinicCommand(int id)
        {
            Id = id;
        }
    }
}
