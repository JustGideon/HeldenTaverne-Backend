using JSFC.HeldenTaverne.Application;
using JSFC.HeldenTaverne.Persistence;
using JustGideon.DSA5CharacterManager.WebAPI.Interfaces;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddApplication();
    builder.Services.AddPersistence();
}

var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();
    }

    // Add Endpoints
    var endpointModuleTypes = EndpointModule.TypesImplementingInterface(typeof(IEndpointModule));
    foreach (var endpointModuleType in endpointModuleTypes)
    {
        var endpoint = (IEndpointModule)Activator.CreateInstance(endpointModuleType)!;
        endpoint.AddRoutes(app);
    }
}

app.Run();