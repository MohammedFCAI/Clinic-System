using ClinicSystem.Core.Features.StatusHistories.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.StatusHistories
{
    public partial class StatusHistoryProfile
    {
        public void AddStatusHistoryMapping()
        {
            CreateMap<AddStatusHistoryCommand, StatusHistory>();
        }
    }
}
