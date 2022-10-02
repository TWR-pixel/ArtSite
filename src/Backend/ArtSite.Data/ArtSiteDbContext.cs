using ArtSite.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtSite.Data;

public sealed class ArtSiteDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Art> Arts { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Comment> Comments { get; set; }

    private readonly string _connectionString;

    public ArtSiteDbContext(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentNullException(nameof(connectionString));

        _connectionString = connectionString;
        Database.EnsureCreated();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_connectionString);
    }
}