using Microsoft.EntityFrameworkCore;
using PlanManager.Domain.Entities;
using PlanManager.Infrastructure.EntityConfigurations;

namespace PlanManager.Infrastructure;

public class PlanManagerDbContext : DbContext
{
    public DbSet<Plan> Plans { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PlanConfig());
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=plan_manager;Username=postgres;Password=toor");
    
}