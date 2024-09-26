var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PlantLadyGoesAspire_Blazor>("plantladygoesaspire-blazor");

builder.AddProject<Projects.PlantLadyGoesAspire_Api>("plantladygoesaspire-api");

builder.AddPostgres("postgres-server")
    .WithPgAdmin();

builder.Build().Run();
