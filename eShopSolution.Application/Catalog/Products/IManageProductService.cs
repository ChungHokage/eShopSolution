﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.Application.DTO;
using eShopSolution.ViewModel.Catalog.Product;
using eShopSolution.ViewModel.Catalog.ProductImage;
using eShopSolution.ViewModel.Catalog.ProductImageViewModel;
using Microsoft.AspNetCore.Http;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task AddViewCount(int productId);

        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<bool> UpdateStock(int productId, int addQuanity);

        Task<int> Delete(int productId);

        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImages(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<ProductImageViewModel> GetImageById(int productId, int imageId);

        Task<ProductImageViewModel> GetImageById(int imageId);
    }
}