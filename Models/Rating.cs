namespace Quill.Models;

public class Rating
{
    public Guid RatingId { get; set; }
    
    public int RatingNumber { get; set; }
    
    public Guid BookId { get; set; }
    
    public Guid UserId { get; set; }
    
    public int Count { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public DateTime? DateModified { get; set; }
    
    public Rating()
    {
        
    }

    public Rating(Guid ratingId)
    {
        
    }
}