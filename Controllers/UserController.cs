using Microsoft.AspNetCore.Mvc;
using Quill.Models;

namespace Quill.Controllers;

[ApiController]
[Route("/user")]
public class UserController : ControllerBase
{
    private Dictionary<Guid, User> _users = new ();
    public UserController()
    {
        var user1 = new User(Guid.NewGuid());
        var user2 = new User(Guid.NewGuid());
        var user3 = new User(Guid.NewGuid());
        var user4 = new User(Guid.NewGuid());
        var user5 = new User(Guid.NewGuid());
        
        _users.Add(user1.UserId, user1);
        _users.Add(user2.UserId, user2);
        _users.Add(user3.UserId, user3);
        _users.Add(user4.UserId, user4);
        _users.Add(user5.UserId, user5);
    }

    [HttpGet]
    public List<User> Get()
    {
        return _users.Values.ToList();
    }

    [HttpGet("/{id}/")]
    public User GetUser(Guid id)
    {
        Console.WriteLine(id);
        foreach (var usersKey in _users.Keys)
        {
            Console.WriteLine(usersKey);
        }

        return _users[id];
    }
}