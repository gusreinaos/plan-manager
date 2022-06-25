using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanManager.Domain.Entities;

namespace PlanManager.Infrastructure.EntityConfigurations;

public class PlanConfig : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.ToTable("plans");
        builder.Property(t => t.Name)
            .IsRequired().HasMaxLength(30);
    }
}