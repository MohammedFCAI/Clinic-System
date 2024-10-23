using ClinicSystem.Core.Features.Clinics.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.Clinics
{
    public partial class ClinicProfile
    {
        public void AddClinicMapping()
        {
            CreateMap<AddClinicCommand, Clinic>();
        }

    }
}
