using System;
using System.Threading.Tasks;
using eShopSolution.Application.DTO;
using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Users;

namespace eShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PageResult<UserViewModel>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(RegisterRequest request);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> DeleteUser(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}