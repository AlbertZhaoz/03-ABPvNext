using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Albert.Bussiness.Products;

public class Product : FullAuditedAggregateRoot<Guid>
{
    public string ProductCode { set; get; }
    public string ProductUrl { set; get; }
    public string ProductTitle { set; get; }
    public string ProductDescription { set; get; }
    public decimal ProductVirtualprice { set; get; }
    public decimal ProductPrice { set; get; }
    public int ProductSort { set; get; }
    public int ProductSold { set; get; }
    public int ProductStock { set; get; }
    public string ProductStatus { set; get; }
    // 这边要注意有商品图片对应的 DTO
    public ICollection<ProductImage> ProductImages { set; get; }

    // 私有构造函数，用于序列化
    public Product()
    {
        ProductImages = new List<ProductImage>();
    }

    // 通过 Guid 来检索商品
    public Product(Guid id) : base(id)
    {
        ProductImages = new List<ProductImage>();
    }
}