using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.ViewModel.System.Users;

namespace eShopSolution.ViewModel.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleViewModel>> GetAll();
    }
}