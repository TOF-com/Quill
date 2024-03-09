using System;

namespace Quill.Models;

public class User(Guid id, string email, string name, int coin)
{
    public Guid Id { get; private set; } = id;

    public string Email { get; set; } = email;

    public string Name { get; set; } = name;

    public int Coin { get; set; } = coin;
}