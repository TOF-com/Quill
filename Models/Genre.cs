namespace Quill.Models;

public class Genre
{
    public Guid GenreId { get; set; }
    
    public string GenreName { get; set; }
    
    public string GenreDescription { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public Genre()
    {
        
    }

    public Genre(Guid genreId)
    {
        
    }
}