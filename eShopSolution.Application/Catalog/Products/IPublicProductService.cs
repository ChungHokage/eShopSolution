using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.Application.DTO;
using eShopSolution.ViewModel.Catalog.Product;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetManageProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
