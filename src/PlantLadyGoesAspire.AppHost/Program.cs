var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.PlantLadyGoesAspire_Api>("plantladygoesaspire-api");

builder.AddProject<Projects.PlantLadyGoesAspire_Blazor>("plantladygoesaspire-blazor")
    .WithReference(api);

builder.Build().Run();
