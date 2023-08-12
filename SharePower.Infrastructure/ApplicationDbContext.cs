using SharePower.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace SharePower.Infrastructure;

public class ApplicationDbContext : DbContext
{
    // public DbSet<User> Users { get; init; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
    }
}