using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Roles;

namespace eShopSolution.AdminApp.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}