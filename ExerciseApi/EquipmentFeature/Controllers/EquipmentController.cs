using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class EquipmentsController : ControllerBase
{
    private readonly IEquipmentFetcherService _equipmentFetcherService;
    private readonly IEquipmentCreateService _equipmentCreateService;
    public EquipmentsController(
        IEquipmentFetcherService equipmentFetcherService,
        IEquipmentCreateService equipmentCreateService)
    {
        _equipmentFetcherService = equipmentFetcherService;
        _equipmentCreateService = equipmentCreateService;
    }
    [HttpGet]
    [Route("Equipments/{equipmentId}")]
    public IActionResult GetEquipment(string equipmentId)
    {
        var result = _equipmentFetcherService.GetEquipmentById(equipmentId);
        return result.Status == OperationStatus.Success ? Ok(result.Result) : BadRequest(result.Message);
    }

    [HttpGet]
    [Route("Equipments")]
    public IActionResult GetEquipments()
    {
        var result = _equipmentFetcherService.GetAllEquipments();
        return result.Status == OperationStatus.Success ? Ok(result.Result) : BadRequest(result.Message);
    }

    [HttpPost]
    [Route("Equipments/Create")]
    public async Task<IActionResult> CreateEquipment([FromBody] EquipmentEntity equipment)
    {
        var result = await _equipmentCreateService.CreateEquipmentAsync(equipment);
        return result.Status == OperationStatus.Success ? Ok(result.Result) : BadRequest(result.Message);
    }
}