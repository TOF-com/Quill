using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Quill.Entities;

namespace Quill.Configuration;

public class DbConfig(IConfiguration configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
    }
    
    public DbSet<User> Users { get; set; }
}