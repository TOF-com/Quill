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
        var user1 = new User(Guid.NewGuid(), "johndoe@gmail.com", "John Doe", 0);
        var user2 = new User(Guid.NewGuid(), "johndoe1@gmail.com", "Finnish Doe", 0);
        var user3 = new User(Guid.NewGuid(), "johndoe2@gmail.com", "Johnson Doe", 0);
        var user4 = new User(Guid.NewGuid(), "johndoe3@gmail.com", "Jay Doe", 0);
        var user5 = new User(Guid.NewGuid(), "johndoe4@gmail.com", "Fin Doe", 0);
        
        _users.Add(user1.Id, user1);
        _users.Add(user2.Id, user2);
        _users.Add(user3.Id, user3);
        _users.Add(user4.Id, user4);
        _users.Add(user5.Id, user5);
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

        id = _users.Keys.ToList()[0];
        return _users[id];
    }
}