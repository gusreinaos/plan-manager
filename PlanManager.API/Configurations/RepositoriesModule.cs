using Autofac;
using PlanManager.Domain.Interfaces;
using PlanManager.Infrastructure;
using PlanManager.Infrastructure.Repositories;

namespace PlanManager.API.Configurations;

public class RepositoriesModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        
        builder.RegisterType<UserRepository>()
                .As<IUserRepository>()
                .InstancePerLifetimeScope();
        
        builder.RegisterType<PlanRepository>()
            .As<IPlanRepository>()
            .InstancePerLifetimeScope();
        
        builder.RegisterType<UserAttendsPlanRepository>()
            .As<IUserAttendsPlanRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<PlanManagerDbContext>().AsSelf();

    }
}