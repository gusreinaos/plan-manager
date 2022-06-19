using System.Reflection;
using Autofac;
using MediatR;

namespace PlanManager.API.Configurations;

public class MediatorModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();
    }
}