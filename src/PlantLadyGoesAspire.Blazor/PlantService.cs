using PlantLadyGoesAspire.Blazor;
using static System.Net.WebRequestMethods;

namespace PlantLadyGoesAspire.Blazor
{
    public class PlantService(HttpClient hc)
    {
        public async Task<Plant[]> GetPlantsAsync(CancellationToken cancellationToken = default)
        {
            Plant[]? plants = null;
            plants = await hc.GetFromJsonAsync<Plant[]>("/getPlants", cancellationToken);
            foreach (var p in plants)
            {
                p.LastWatered = DateOnly.FromDateTime(DateTime.Now.AddDays(-7));
            }
            return plants;

        }


    }
}

public record class Plant(string Name, string? Sunlight, string? Summary)
{
    public DateOnly LastWatered { get; set; } 
}