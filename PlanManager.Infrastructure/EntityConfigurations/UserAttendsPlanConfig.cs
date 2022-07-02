using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanManager.Domain.Entities;

namespace PlanManager.Infrastructure.EntityConfigurations;

public class UserAttendsPlanConfig : IEntityTypeConfiguration<UserAttendsPlan>
{
    public void Configure(EntityTypeBuilder<UserAttendsPlan> builder)
    {
        builder.ToTable("user_attends_plans");
        builder.HasKey(up => up.Id);
    }
}