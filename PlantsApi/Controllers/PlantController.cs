using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlantsApi.Services.PlantService;

namespace PlantApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlantController : ControllerBase
{
    private readonly IPlantService _plantService;
    public PlantController(IPlantService plantService)
    {
        _plantService = plantService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Plant>>> Get()
    {
        var result = await _plantService.Get();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Plant>> GetById(int id)
    {
        var result = await _plantService.GetById(id);
        if (result == null)
            return NotFound("Plant does not exist");
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<List<Plant>>> AddPlant(Plant plant)
    {
        var result = await _plantService.AddPlant(plant);
        return Ok(result);
    }

    [HttpPut]
    public async Task<ActionResult<List<Plant>>> UpdatePlant(Plant request)
    {
        var result = await _plantService.UpdatePlant(request);
        if (result == null)
            return NotFound("Plant not found");
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Plant>>> DeletePlant(int id)
    {
        var result = await _plantService.DeletePlant(id);
        if (result == null)
            return NotFound("Plant not found");
        return Ok(result);
    }
}
