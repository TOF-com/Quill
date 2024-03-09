namespace Quill.Models;

public class UserGenre
{
    public Guid UserGenreId { get; set; }
    
    public Guid UserId { get; set; }
    
    public Guid GenreId { get; set; }
    
    public UserGenre()
    {
        
    }

    public UserGenre(Guid userGenreId)
    {
        
    }
    
}