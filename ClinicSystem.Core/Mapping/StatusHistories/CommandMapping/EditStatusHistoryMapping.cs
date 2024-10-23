using ClinicSystem.Core.Features.StatusHistories.Commands.Models;
using ClinicSystem.Data.Entities;

namespace ClinicSystem.Core.Mapping.StatusHistories
{
    public partial class StatusHistoryProfile
    {
        public void EditStatusHistoryMapping()
        {
            CreateMap<EditStatusHistoryCommand, StatusHistory>().ForMember(dest => dest.StatusHistoryId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
