using AutoMapper;

namespace ClinicSystem.Core.Mapping.StatusHistories
{
    public partial class StatusHistoryProfile : Profile
    {
        public StatusHistoryProfile()
        {
            AddStatusHistoryMapping();
            EditStatusHistoryMapping();
            GetStatusHistoryListMapping();
            GetStatusHistoryByIdMapping();
        }
    }
}
