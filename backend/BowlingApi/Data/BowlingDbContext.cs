using Microsoft.EntityFrameworkCore;

namespace BowlingApi.Data;

public class BowlingDbContext : DbContext
{
    public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options) { }
    public DbSet<Bowler> Bowlers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bowler>().HasNoKey();
    }
}