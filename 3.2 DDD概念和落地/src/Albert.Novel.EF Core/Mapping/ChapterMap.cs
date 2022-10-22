using Albert.Novel.Domain.Book.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Albert.Novel.EF_Core;

public class ChapterMap:IEntityTypeConfiguration<Chapter>
{
    public void Configure(EntityTypeBuilder<Chapter> builder)
    {
        // 对实体配置基本属性和约定，必须要有
        builder.ConfigureByConvention();
        
        // 其他列配置
        builder.ToTable(nameof(Chapter));
        builder.Property(chapter => chapter.Title)
            .IsRequired()
            .HasMaxLength(20);
    }
}