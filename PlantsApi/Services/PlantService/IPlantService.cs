namespace PlantsApi.Services.PlantService;

public interface IPlantService
{
    Task<List<Plant>> Get();
    Task<Plant?> GetById(int id);
    Task<List<Plant>> AddPlant(Plant plant);
    Task<List<Plant>?> UpdatePlant(Plant request);
    Task<List<Plant>?> DeletePlant(int id);
}