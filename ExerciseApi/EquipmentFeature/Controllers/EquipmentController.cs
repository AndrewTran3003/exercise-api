using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher;
using ExerciseApi.Helpers;
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
        return result.Status == OperationStatus.Success ? Ok (result.Result) : BadRequest(result.Message);
    }

    [HttpGet]
    [Route("Equipments")]
    public IActionResult GetEquipments()
    {   var result = _equipmentFetcherService.GetAllEquipments();
        return result.Status == OperationStatus.Success ? Ok (result.Result) : BadRequest(result.Message);
    }
}