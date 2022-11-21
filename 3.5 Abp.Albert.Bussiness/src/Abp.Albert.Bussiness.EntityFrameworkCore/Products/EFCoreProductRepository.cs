using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Albert.Bussiness.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Albert.Bussiness.Products
{
    [Dependency(ServiceLifetime.Transient)]
    public class ProductRepository: EfCoreRepository<BussinessDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<BussinessDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<IEnumerable<Product>> GetProductListAsync()
        {
            // 第二种查询方式: Abp.vNext 封装好的
            // 连表查询
            return GetDbSetAsync().Result.Include(product => product.ProductImages).ToList();
        }

        // 通过名字来获取全部的商品
        public async Task<IEnumerable<Product>> GetProductByNameAsync(string ProductTitle)
        {
            // 第一种方式:EFCore查询方式 数据库所有产品
            var dbContext = await GetDbContextAsync();
            var productsBydbContext = dbContext.Products.Where(p => p.ProductTitle == ProductTitle);
            return productsBydbContext;

            // 下面这种方式是执行原生的sql
            // await dbContext.Database.ExecuteSqlRawAsync($"Select * FROM Product WHERE ProductTitle = {ProductTitle}");
        }

        // 插入模拟数据
        public async Task InsertMockData()
        {
            List<Product> productList = new List<Product>() { };
            for (int i = 0; i < 10; i++)
            {
                var productGuid = GuidGenerator.Create();
                var product = new Product(productGuid)
                {
                    ProductCode = $"00{i}",
                    ProductUrl = $"http://www.00{i}product.com",
                    ProductTitle = $"00{i}Title",
                    ProductDescription = $"00{i}Description",
                    ProductVirtualprice = i * 100,
                    ProductPrice = i * 100,
                    ProductSort = i,
                    ProductSold = i * 1,
                    ProductStock = i * 10,
                    ProductStatus = "1",
                    ProductImages = new List<ProductImage>()
                    {
                        new ProductImage(GuidGenerator.Create())
                        {
                            ProductId = productGuid,
                            ImageSort = 1,
                            ImageStatus = "1",
                            ImageUrl = $"http://www.001product{i}image.com",
                        },
                        new ProductImage(GuidGenerator.Create())
                        {
                            ProductId = productGuid,
                            ImageSort = 2,
                            ImageStatus = "2",
                            ImageUrl = $"http://www.002product{i}image.com",
                        },
                        new ProductImage(GuidGenerator.Create())
                        {
                            ProductId = productGuid,
                            ImageSort = 3,
                            ImageStatus = "3",
                            ImageUrl = $"http://www.003product{i}image.com",
                        }
                    }
                };
                productList.Add(product);
            }
            var dbContext = await GetDbContextAsync();
            dbContext.Products.AddRange(productList);
            await dbContext.SaveChangesAsync();
        }
    }
}
