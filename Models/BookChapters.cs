namespace Quill.Models;

public class BookChapters
{
    public Guid BookChapterId { get; set; }
    
    public string Title { get; set; }
    
    public Guid BookId { get; set; }
    
    public string Content { get; set; }
    
    public DateTime? DatePublished { get; set; }
    
    public bool IsLocked { get; set; }
    
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public int UnlockCost { get; set; }
    
    public BookChapters()
    {
        
    }

    public BookChapters(Guid bookChapterId)
    {
        
    }
}