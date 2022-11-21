using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Abp.Albert.Bussiness.ProductDtos
{
    public class CreateProductDto: FullAuditedEntityDto<Guid>
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
        public CreateProductImageDto[] ProductImages { set; get; }// 商品图片

        // 默认设置软删除为 false，避免查询不到数据的尴尬
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
