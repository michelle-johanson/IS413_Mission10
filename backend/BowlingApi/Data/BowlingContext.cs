using BowlingApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BowlingApi.Data;

public class BowlingContext : DbContext
{
    public BowlingContext(DbContextOptions<BowlingContext> options) : base(options) { }
    public DbSet<Bowler> Bowlers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bowler>().HasNoKey();
    }
}