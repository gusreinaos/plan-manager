using Autofac;
using PlanManager.Domain.Interfaces;
using PlanManager.Infrastructure.Repositories;

namespace PlanManager.API.Configurations;

public class RepositoriesModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        
         builder.RegisterType<UserRepository>()
                .As<IUserRepository>()
                .InstancePerLifetimeScope();
         
    }
}