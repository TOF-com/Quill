using System;

namespace Quill.Models;

public class Author
{
    public Guid AuthorId { get; set; }
    
    public Guid UserId { get; set; }
    
    public string PenName { get; set; }
    
    public DateOnly? DateOfBirth { get; set; }
    
    public DateTime BecameAuthorOn { get; set; }
    
    public string? ShortBio { get; set; }

    public Author()
    {
        
    }

    public Author(Guid authorId)
    {
        AuthorId = authorId;
    }
    
}