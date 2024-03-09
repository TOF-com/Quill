namespace Quill.Models;

public class BookType
{
    public Guid BookTypeId { get; set; }

    public Guid BookId { get; set; }
    
    public string TypeName { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
    
    public BookType()
    {
        
    }

    public BookType(Guid bookTypeId)
    {
        
    }
}