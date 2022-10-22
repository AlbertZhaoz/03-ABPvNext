using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Albert.Novel.Domain.Book.Entities;

public class ChapterText:Entity<Guid>,IHasCreationTime
{
    public string Content { get; set; }
    public string Notes { get; set; }
    public DateTime CreationTime { get; }

    protected ChapterText()
    {
        
    }

    public ChapterText(string content,string notes = null)
    {
        this.Content = content;
        this.Notes = notes;
    }
}