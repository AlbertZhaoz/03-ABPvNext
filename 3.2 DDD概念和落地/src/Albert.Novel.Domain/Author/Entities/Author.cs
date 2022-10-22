using Volo.Abp.Domain.Entities;

namespace Albert.Novel.Domain.Author.Entities;

public class Author:Entity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    // 实体都需要构造两个构造函数
    // 1.不对外开放(protected：本类或其子类可以访问)，提供给ORM框架
    // 用来从数据库中获取实体以创建实体用的。
    // 2.公开的构造函数，传入一个 Guid
    protected Author()
    {
        
    }

    // 推荐使用 Abp 中的 Guid 生成器。
    public Author(Guid guid,string name,string description = null)
    {
        
    }
}