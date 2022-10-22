using Albert.Novel.Domain.Author.Entities;
using Albert.Novel.Domain.Book.Entities;
using Albert.Novel.Domain.Category.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Albert.Novel.EF_Core;

public class CategoryMap:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // 对实体配置基本属性和约定，必须要有
        builder.ConfigureByConvention();
        
        // 其他列配置
        builder.ToTable(nameof(Category));
        builder.Property(category => category.Name)
            .IsRequired()
            .HasMaxLength(20);
    }
}