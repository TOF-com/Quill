namespace Quill.Models;

public class Book
{
    public Guid BookId { get; set; }
    
    public string Title { get; set; }
    
    public Guid AuthorId { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public EBookStatus Status { get; set; }
    
    public DateTime DatePublished { get; set; }
    
    public string? Synopsis { get; set; }
    
    public int? CategoryRank { get; set; }
    
    public Author? ModifiedBy { get; set; }
    
    public Author CreatedBy { get; set; }

    public int Views { get; set; }
    
    public Guid BookTypeId { get; set; }
    
    public Book()
    {
        
    }

    public Book(Guid bookId)
    {
        
    }
}