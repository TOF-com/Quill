using System;

namespace Quill.Models;

public class User
{
    public Guid UserId { get; set; }

    public string Email { get; set; }

    public string Name { get; set; }

    public int Coin { get; set; }

    public DateTime DateJoined { get; set; }
    
    public User(string email, string name)
    {
        Email = email;
        Name = name;
        UserId = Guid.NewGuid();
    }

    public User(Guid userId, string email, string name)
    {
        UserId = userId;
        Email = email;
        Name = name;
    }
    
}