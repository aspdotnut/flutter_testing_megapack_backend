using Microsoft.EntityFrameworkCore;
using flutter_testing_megapack_backend.Models;

namespace flutter_testing_megapack_backend.Data;

public class MegapackDbContext : DbContext
{
    public DbSet<TodoItem> TodoItems { get; set; }
    public DbSet<Password> Passwords { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;" + // Server name
            "port=3306;" + // Server port
            "user=root;" + // Username
            "password=;" + // Password
            "database=flutter_testing_megapack_db;" // Database name
            , ServerVersion.Parse("10.4.27-MariaDB") // Version
        );
    }
}