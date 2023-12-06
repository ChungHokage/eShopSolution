using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.ViewModel.Common;

namespace eShopSolution.ViewModel.System.Users
{
    public class RoleAssignRequest
    {
        public Guid UserId { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}