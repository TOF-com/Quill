namespace Quill.Models;

public class Comment
{
    public Guid CommentId { get; set; }

    public string CommentText { get; set; }
    
    public Guid BookChapterId { get; set; }
    
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
    
    public Guid UserId { get; set; }
    
    public Comment()
    {
        
    }

    public Comment(Guid commentId)
    {
        
    }
}