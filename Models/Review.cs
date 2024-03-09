namespace Quill.Models;

public class Review
{
    public Guid ReviewId { get; set; }
    
    public string ReviewText { get; set; }
    
    public Guid BookId { get; set; }
    
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
    
    public Guid UserId { get; set; }
    
    public int Rating { get; set; }
    
    public Review()
    {
        
    }

    public Review(Guid reviewId)
    {
        
    }
}