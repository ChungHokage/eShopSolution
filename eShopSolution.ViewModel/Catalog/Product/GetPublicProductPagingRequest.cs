using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.DTO;

namespace eShopSolution.ViewModel.Catalog.Product
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
