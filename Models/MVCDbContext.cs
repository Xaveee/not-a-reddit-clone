
using ASP_MVC_App.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

public class MVCDbContext : DbContext
{
    public MVCDbContext(DbContextOptions<MVCDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }

    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
