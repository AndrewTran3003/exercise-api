using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class EquipmentsController : ControllerBase
{
    private readonly IEquipmentFetcherService _equipmentFetcherService;
    public EquipmentsController(IEquipmentFetcherService equipmentFetcherService){
        _equipmentFetcherService = equipmentFetcherService;
    }
    [HttpGet]
    [Route("Equipments/{equipmentId}")]
    public IActionResult GetEquipment(string equipmentId)
    {
        var result = _equipmentFetcherService.GetEquipmentById(equipmentId);
        return Ok(result);
    }

    [HttpGet]
    [Route("Equipments")]
    public IActionResult GetEquipments()
    {   var result = _equipmentFetcherService.GetAllEquipments();
        return Ok(result);
    }
}