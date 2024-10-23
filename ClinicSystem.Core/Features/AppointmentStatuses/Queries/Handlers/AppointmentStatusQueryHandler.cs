using AutoMapper;
using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.AppointmentStatuses.Queries.Models;
using ClinicSystem.Core.Features.AppointmentStatuses.Queries.Responses;
using ClinicSystem.Service.Abstracts;
using MediatR;

namespace ClinicSystem.Core.Features.AppointmentStatuses.Queries.Handlers
{
    public class AppointmentStatusQueryHandler : CusResponseHandler,
        IRequestHandler<GetAppointmentStatusListQuery, CusResponse<List<GetAppointmentStatusListResponse>>>,
        IRequestHandler<GetAppointmentStatusLByIdQuery, CusResponse<GetSingleAppointmentStatusResponse>>
    {

        #region Fileds
        private readonly IAppointmentStatusService _appointmentStatusService;
        private readonly IMapper _mapper;

        #endregion

        #region Constructors
        public AppointmentStatusQueryHandler(IAppointmentStatusService appointmentStatusService, IMapper mapper)
        {
            _appointmentStatusService = appointmentStatusService;
            _mapper = mapper;
        }
        #endregion

        #region Functions

        #endregion
        public async Task<CusResponse<List<GetAppointmentStatusListResponse>>> Handle(GetAppointmentStatusListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var list = await _appointmentStatusService.GetAppointmentStatusListAsync();
                var listMapper = _mapper.Map<List<GetAppointmentStatusListResponse>>(list);
                return Success(listMapper);

            }
            catch (Exception ex)
            {
                return ServerError<List<GetAppointmentStatusListResponse>>(ex.Message);
            }
        }

        public async Task<CusResponse<GetSingleAppointmentStatusResponse>> Handle(GetAppointmentStatusLByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var single = await _appointmentStatusService.GetAppointmentStatusByIdAsync(request.Id);
                var singleMapper = _mapper.Map<GetSingleAppointmentStatusResponse>(single);
                if (singleMapper == null)
                    return NotFound<GetSingleAppointmentStatusResponse>("the appointment status not exist.");

                return Success(singleMapper);

            }
            catch (Exception ex)
            {
                return ServerError<GetSingleAppointmentStatusResponse>(ex.Message);
            }
        }
    }
}
