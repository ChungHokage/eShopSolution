using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.ViewModel.Common;

namespace eShopSolution.Application.DTO
{
    public class PagingRequestBase : RequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}