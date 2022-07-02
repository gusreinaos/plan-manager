using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using PlanManager.Domain.Entities;
using PlanManager.Infrastructure.EntityConfigurations;

namespace PlanManager.Infrastructure;

public class PlanManagerDbContext : DbContext
{
    public DbSet<Plan> Plans { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserAttendsPlan> UserAttendsPlan { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PlanConfig());
        modelBuilder.ApplyConfiguration(new UserConfig());
        modelBuilder.ApplyConfiguration(new UserAttendsPlanConfig());
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=plan_manager;Username=postgres;Password=toor");
    
}