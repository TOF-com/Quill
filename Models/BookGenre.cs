namespace Quill.Models;

public class BookGenre
{
    public Guid BookGenreId { get; set; }
    
    public Guid BookId { get; set; }
    
    public Guid GenreId { get; set; }
    
    public BookGenre()
    {
        
    }

    public BookGenre(Guid bookGenreId)
    {
        
    }
}