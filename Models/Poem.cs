namespace Quill.Models;

public class Poem
{
    public Guid PoemId { get; set; }
    
    public string Title { get; set; }
    
    public string? Theme { get; set; }
    
    public Guid BookId { get; set; }
    
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
    
    public string Content { get; set; }
    
    public Poem()
    {
        
    }

    public Poem(Guid poemId)
    {
        
    }
}