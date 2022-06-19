using Autofac;
using Autofac.Extensions.DependencyInjection;
using PlanManager.API.Configurations;

var builder = WebApplication.CreateBuilder(args);

/*Indicates the server how to cast the ContainerBuilder
 This is all in the AutoFac configuration webpage*/
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

/*ContainerBuilder so that we are able to configure the builder for the server in which we include the modules of the
 configuration*/
builder.Host.ConfigureContainer<ContainerBuilder>((builder) =>
{
    builder.RegisterModule(new MediatorModule());
    builder.RegisterModule(new RepositoriesModule());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();