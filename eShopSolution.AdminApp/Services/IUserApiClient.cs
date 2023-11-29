using System.Threading.Tasks;
using eShopSolution.Application.DTO;
using eShopSolution.ViewModel.System.Users;

namespace eShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PageResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest request);
    }
}