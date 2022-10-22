using System.Reflection;
using Albert.Novel.Domain.Author.Entities;
using Albert.Novel.Domain.Book.Entities;
using Albert.Novel.Domain.Category.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Albert.Novel.EF_Core;

[ConnectionStringName("Novel")]
public class NovelDbContext:AbpDbContext<NovelDbContext>
{
    // 配置聚合的 DbSet
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Book> Books { get; set; }
    public DbSet<Volume> Volumes { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    public DbSet<ChapterText> ChapterTexts { get; set; }

    public NovelDbContext(DbContextOptions<NovelDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}