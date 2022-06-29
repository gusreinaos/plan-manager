using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanManager.Domain.Entities;

namespace PlanManager.Infrastructure.EntityConfigurations;

public class PlanConfig : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.ToTable("plans");
        builder.Property(t => t.Id);
        builder.HasKey(t => t.Id); //primary key for plan
        builder.Property(t => t.Name);
        builder.Property(t => t.Latitude);
        builder.Property(t => t.Longitude);
        builder.Property(t => t.Description);
        //builder.Property(t => t.OwnerId);
        //builder.Property(t => t.InvitedUsersId);
    }
}