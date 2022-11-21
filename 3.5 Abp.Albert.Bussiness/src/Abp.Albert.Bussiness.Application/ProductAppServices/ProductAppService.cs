using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Albert.Bussiness.Permissions;
using Abp.Albert.Bussiness.ProductAppSerivices;
using Abp.Albert.Bussiness.ProductDtos;
using Abp.Albert.Bussiness.Products;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Albert.Bussiness.ProductAppServices
{
    public class ProductAppService:CrudAppService<Product,ProductDto,Guid,PagedAndSortedResultRequestDto,CreateProductDto,UpdateProductDto>,IProductAppService
    {
        public IProductRepository _productRepository;
        public ProductAppService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

        [Authorize(BussinessPermissions.Product.DefaultSelectByTitle)]
        public async Task<IEnumerable<ProductDto>> GetProductByNameAsync(string ProductTitle)
        {
            // 通过仓储接口获取商品
           var products = await _productRepository.GetProductByNameAsync(ProductTitle);
           var productsDto = ObjectMapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
           return productsDto;
        }

        // 用户必须登录才可以访问这个接口
        [Authorize]
        public async Task<IEnumerable<ProductDto>> GetProductListAsync()
        {
            // 通过仓储接口获取商品
            var products = await _productRepository.GetProductListAsync();
            var productsDto = ObjectMapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(products);
            return productsDto;
        }

        public async Task InserMockAsync()
        {
            try
            {
                await _productRepository.InsertMockData();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
