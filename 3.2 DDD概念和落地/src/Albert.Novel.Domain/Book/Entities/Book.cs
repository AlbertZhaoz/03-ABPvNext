using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Albert.Novel.Domain.Book.Entities;

// 实现审计接口 可以自动实现某些值
// 比如 IHasCreationTime 可以生成创建时间
public class Book:Entity<Guid>,IHasCreationTime
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    // 聚合和聚合关联，通过 ID
    public Guid AuthorId { get; set; }
    // 可以做一些适当的冗余，比如作者名称
    public string AuthroName { get; set; }
    
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }
    
    // 聚合根内部的聚合使用导航属性
    // 子集的构造函数总是从内部设置，而不是外部设置，这边增加 protected
    // 子导航属性都是 protected 修饰
    public List<Volume> Volumes { get; protected set; }
    
    public DateTime CreationTime { get; }

    protected Book()
    {
        
    }

    // 其中还进行了一些规则的检测
    public Book(Guid id,
        string name,
        string description,
        Guid authorId,
        string authroName,
        Guid categoryId,
        string categoryName)
    {
        this.Id = id;
        this.Name = Check.NotNullOrWhiteSpace(name,nameof(name));
        this.Description = Check.NotNullOrWhiteSpace(description,nameof(description));
        this.AuthorId = authorId;
        this.AuthroName = Check.NotNullOrWhiteSpace(authroName,nameof(authroName));
        this.CategoryId = categoryId;
        this.CategoryName = Check.NotNullOrWhiteSpace(categoryName,nameof(categoryName));
        // 这里注意对子集的初始化
        this.Volumes = new List<Volume>();
    }

    public void AddVolume(Volume vol)
    {
        if (Volumes.Any(v => v.Title != vol.Title))
        {
            this.Volumes.Add(vol);
        }
    }

    public void RemoveVolumn(Guid volId)
    {
        Volumes.RemoveAll(v => v.Id == volId);
    }
}