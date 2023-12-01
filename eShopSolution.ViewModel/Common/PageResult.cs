using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.ViewModel.Common;

namespace eShopSolution.Application.DTO
{
    public class PageResult<T> : PageResultBase
    {
        public List<T> Items { get; set; }
    }
}