using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


app.MapGet("/getPlants", () =>
{
    var plants = JsonSerializer.Deserialize<Plant[]>(System.IO.File.ReadAllText("plants.json")) ?? Array.Empty<Plant>();
    return plants;
})
.WithOpenApi();

app.Run();

internal record Plant(string Name, DateOnly LastWatered, string? Sunlight, string? Summary)
{
}
