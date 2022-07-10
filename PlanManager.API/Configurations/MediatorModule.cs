using System.Reflection;
using Autofac;
using FluentValidation;
using MediatR;
using PlanManager.Application.Commands.PlanCommands;
using PlanManager.Application.Validators;
using PlanManager.Application.Validators.Commands;
using PlanManager.Infrastructure.Behaviours;

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
        
        builder.RegisterGeneric(typeof(ValidatorBehaviour<,>)).As(typeof(IPipelineBehavior<,>));
        
        // Register the Command's Validators (Validators based on FluentValidation library)
        builder
            .RegisterAssemblyTypes(typeof(CreatePlanCommandValidator).GetTypeInfo().Assembly)
            .Where(t => t.IsClosedTypeOf(typeof(IValidator<>)))
            .AsImplementedInterfaces();
    }
}