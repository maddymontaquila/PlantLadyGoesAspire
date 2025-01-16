var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.PlantLadyGoesAspire_Api>("plants-api");

builder.AddProject<Projects.PlantLadyGoesAspire_Blazor>("frontend")
    .WithReference(api);

builder.Build().Run();
