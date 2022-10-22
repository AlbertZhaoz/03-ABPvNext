using Albert.Novel.Domain.Author.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Albert.Novel.EF_Core;

public class AuthorMap:IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        // 对实体配置基本属性和约定，必须要有
        builder.ConfigureByConvention();
        
        // 其他列配置
        builder.ToTable(nameof(Author));
        builder.Property(author => author.Name)
            .IsRequired()
            .HasMaxLength(20);
        builder.Property(author => author.Description)
            .HasMaxLength(100);

    }
}