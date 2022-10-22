using Albert.Novel.Domain.Book.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Albert.Novel.EF_Core;

public class ChapterTextMap:IEntityTypeConfiguration<ChapterText>
{
    public void Configure(EntityTypeBuilder<ChapterText> builder)
    {
        builder.ConfigureByConvention();

        builder.Property(c => c.Content)
            .IsRequired()
            .HasMaxLength(200);
    }
}