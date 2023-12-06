using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.Application.DTO;
using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Users;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace eShopSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<ApiResult<PageResult<UserViewModel>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}