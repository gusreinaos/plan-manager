using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanManager.Domain.Entities;

namespace PlanManager.Infrastructure.EntityConfigurations;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");
        builder.Property(t => t.Id);
        builder.HasKey(t => t.Id);
        builder.Property(t => t.FullName);
        builder.Property(t => t.Email);
        builder.Property(t => t.Password);
    }
}