using AutoMapper;
using ClinicSystem.Core.BasesCore;
using ClinicSystem.Core.Features.Authorizations.Queries.Models;
using ClinicSystem.Core.Features.Authorizations.Queries.Responses;
using ClinicSystem.Data.Entities.Identities;
using ClinicSystem.Data.Helpers;
using ClinicSystem.Service.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ClinicSystem.Core.Features.Authorizations.Queries.Handlers
{
    public class RoleQueryHandler : CusResponseHandler,
        IRequestHandler<GetRoleByIdQuery, CusResponse<GetRoleByIdResponse>>,
        IRequestHandler<GetRoleListQuery, CusResponse<List<GetRoleListResponse>>>,
        IRequestHandler<ManagerUserRolesQuery, CusResponse<ManagerUserRolesResponse>>
    {
        #region Fileds
        private readonly IAuthorizationService _authorizationService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        #endregion

        #region Constructors
        public RoleQueryHandler(IAuthorizationService authorizationService,
            IMapper mapper, UserManager<User> userManager)
        {
            _authorizationService = authorizationService;
            _mapper = mapper;
            _userManager = userManager;
        }
        #endregion

        #region Functions
        public async Task<CusResponse<GetRoleByIdResponse>> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var role = await _authorizationService.GetRoleByID(request.Id);
                if (role == null)
                    return NotFound<GetRoleByIdResponse>("role with this Id not Found!");

                var roleMapper = _mapper.Map<GetRoleByIdResponse>(role);
                return Success(roleMapper);
            }
            catch (Exception ex)
            {
                return ServerError<GetRoleByIdResponse>(ex.Message);
            }
        }

        public async Task<CusResponse<List<GetRoleListResponse>>> Handle(GetRoleListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var roles = await _authorizationService.GetRoleListAsync();
                if (roles == null)
                {
                    return NotFound<List<GetRoleListResponse>>("Not Found Roles");
                }

                var rolesMapper = _mapper.Map<List<GetRoleListResponse>>(roles);
                return Success(rolesMapper);
            }
            catch (Exception ex)
            {
                return ServerError<List<GetRoleListResponse>>(ex.Message);
            }
        }

        public async Task<CusResponse<ManagerUserRolesResponse>> Handle(ManagerUserRolesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(request.Id.ToString());
                if (user == null)
                    return NotFound<ManagerUserRolesResponse>("user with this Id not Found!");

                var result = await _authorizationService.GetManagerUsersRolesData(user);
                return Success(result);
            }
            catch (Exception ex)
            {
                return ServerError<ManagerUserRolesResponse>(ex.Message);
            }
        }
        #endregion
    }
}
