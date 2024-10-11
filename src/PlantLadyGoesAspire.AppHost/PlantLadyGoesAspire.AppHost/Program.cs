var builder = DistributedApplication.CreateBuilder(args);



var db = builder.AddPostgres("postgres-server")
    .WithPgAdmin();

var api = builder.AddProject<Projects.PlantLadyGoesAspire_Api>("plantladygoesaspire-api")
    .WithReference(db);

builder.AddProject<Projects.PlantLadyGoesAspire_Blazor>("plantladygoesaspire-blazor")
    .WithReference(api);


builder.Build().Run();
