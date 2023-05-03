using Azure.Core;
using Microsoft.AspNetCore.Mvc;

namespace PlantsApi.Services.PlantService;

public class PlantService : IPlantService
{
    //private static List<Plant> _plants = new List<Plant>
    //{
    //    new Plant
    //    {
    //        Id = 1,
    //        Name = "Oregeno",
    //        Zone = "6a"
    //    },
    //    new Plant
    //    {
    //        Id = 2,
    //        Name = "Mint",
    //        Zone = "5b"
    //    }
    //};

    public DataContext _context { get; }

    public PlantService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Plant>> Get()
    {
        return await _context.Plants.ToListAsync();
    }

    public async Task<Plant?> GetById(int id)
    {
        var plant = await _context.Plants.FindAsync(id);

        if (plant is null)
            return null;

        return plant;
    }

    public async Task<List<Plant>> AddPlant(Plant plant)
    {
        _context.Plants.Add(plant);
        await _context.SaveChangesAsync();
        return await _context.Plants.ToListAsync();
    }

    public async Task<List<Plant>?> UpdatePlant(Plant request)
    {
        var plant = await _context.Plants.FindAsync(request.Id);
        if (plant is null)
            return null;

        plant.BinomialNomenclature = request.BinomialNomenclature;
        plant.Name = request.Name;
        plant.Description = request.Description;
        plant.Zones = request.Zones;

        await _context.SaveChangesAsync();

        return await _context.Plants.ToListAsync();
    }

    public async Task<List<Plant>?> DeletePlant(int id)
    {
        var plant = await _context.Plants.FindAsync(id);
        if (plant is null)
            return null;

        _context.Plants.Remove(plant);
        await _context.SaveChangesAsync();

        return await _context.Plants.ToListAsync();
    }
}