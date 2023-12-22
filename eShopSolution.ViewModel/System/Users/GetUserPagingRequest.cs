using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.DTO;

namespace eShopSolution.ViewModel.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}