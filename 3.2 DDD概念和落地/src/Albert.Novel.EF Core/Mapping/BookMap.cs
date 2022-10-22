using Albert.Novel.Domain.Author.Entities;
using Albert.Novel.Domain.Book.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Albert.Novel.EF_Core;

public class BookMap:IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        // 对实体配置基本属性和约定，必须要有
        builder.ConfigureByConvention();
        
        // 其他列配置
        builder.ToTable(nameof(Book));
        builder.Property(book => book.Name)
            .IsRequired()
            .HasMaxLength(20);
        builder.Property(book => book.Description)
            .HasMaxLength(100);
    }
}