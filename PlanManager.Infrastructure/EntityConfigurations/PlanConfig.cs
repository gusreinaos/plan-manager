using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanManager.Domain.Entities;

namespace PlanManager.Infrastructure.EntityConfigurations;

public class PlanConfig : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.ToTable("plans");
        
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Name).IsRequired().HasMaxLength(20);
        builder.Property(t => t.Latitude).IsRequired().HasMaxLength(40);
        builder.Property(t => t.Longitude).IsRequired().HasMaxLength(40);
        builder.Property(t => t.Description).IsRequired().HasMaxLength(50);
        
    }
}