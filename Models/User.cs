namespace Quill.Models;

public class User
{
    public Guid UserId { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public int Coin { get; set; }

    public DateTime DateJoined { get; set; }
    
    public User(){}

    public User(Guid userId)
    {
        
    }
    
}