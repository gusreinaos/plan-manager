using System.Reflection;
using Autofac;
using MediatR;
using PlanManager.Application.Commands.PlanCommands;

namespace PlanManager.API.Configurations;

public class MediatorModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();
        // Registrar todas las clases command que  implementen el IRequestHandler
        builder.RegisterAssemblyTypes(typeof(CreatePlanCommand).GetTypeInfo().Assembly).AsClosedTypesOf(typeof(IRequestHandler<,>));
        
        builder.Register<ServiceFactory>(context =>
        {
            var componentContext = context.Resolve<IComponentContext>();
            return t =>
            {
                object o;
                return componentContext.TryResolve(t, out o) ? o : null;
            };
        });
    }
}