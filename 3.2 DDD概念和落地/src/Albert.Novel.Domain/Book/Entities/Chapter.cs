using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Albert.Novel.Domain.Book.Entities;

// 书-卷-章节-章节正文
public class Chapter:Entity<Guid>,IHasCreationTime
{
    // 聚合内部可以使用导航属性
    public Volume Volume { get; set; }
    public Guid VolumeId { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public int WordsNumber { get; set; }

    // 子导航属性都是 protected 修饰
    public ChapterText ChapterText { get; protected set; }
    
    public DateTime CreationTime { get; }

    protected Chapter()
    {
        
    }

    public Chapter(string title,string description,string content)
    {
        this.Title = Check.NotNullOrWhiteSpace(title,nameof(title));
        this.Description = description;
        this.WordsNumber = content.Length;
        this.ChapterText = new ChapterText(content);
    }
}