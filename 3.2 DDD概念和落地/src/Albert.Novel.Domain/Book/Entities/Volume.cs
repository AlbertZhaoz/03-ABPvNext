using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Albert.Novel.Domain.Book.Entities;

// 书-卷-章节-章节正文
public class Volume : Entity<Guid>, IHasCreationTime
{
    // 聚合内部可以使用导航属性
    public Book Book { get; set; }
    public Guid BookId { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    // 子导航属性都是 protected 修饰
    public List<Chapter> Chapters { get; protected set; }
    
    public DateTime CreationTime { get; }

    protected Volume()
    {
        
    }

    public Volume(string title,string description=null)
    {
        this.Title = title;
        this.Description = description;
    }

    public void AddChapter(Chapter chapter)
    {
        if (Chapters.Any(c => c.Title != chapter.Title))
        {
            Chapters.Add(chapter);
        }
    }
}