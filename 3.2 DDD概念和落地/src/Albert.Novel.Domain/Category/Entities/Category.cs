using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Albert.Novel.Domain.Category.Entities;

public class Category:Entity<Guid>,IHasCreationTime
{
    public string Name { get; set; }
    
    public DateTime CreationTime { get; }

    protected Category()
    {
        
    }

    public Category(Guid id,string name)
    {
        // 只有聚合根才需要暴露 Id
        this.Id = id;
        this.Name = name;
    }
}