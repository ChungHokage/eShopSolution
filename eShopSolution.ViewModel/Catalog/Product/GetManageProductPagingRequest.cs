using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.DTO;

namespace eShopSolution.ViewModel.Catalog.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
