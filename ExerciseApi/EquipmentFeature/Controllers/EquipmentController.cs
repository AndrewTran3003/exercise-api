using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentCreate.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentFetcher.Service;
using ExerciseApi.EquipmentFeature.EquipmentServices.EquipmentUpdate.Service;
using ExerciseApi.EquipmentFeature.Models;
using ExerciseApi.Helpers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("{controller}")]
public class EquipmentsController : ControllerBase
{
    private readonly IEquipmentFetcherService _equipmentFetcherService;
    private readonly IEquipmentCreateService _equipmentCreateService;
    private readonly IEquipmentUpdateService _equipmentUpdateService;
    public EquipmentsController(
        IEquipmentFetcherService equipmentFetcherService,
        IEquipmentCreateService equipmentCreateService,
        IEquipmentUpdateService equipmentUpdateService)
    {
        _equipmentFetcherService = equipmentFetcherService;
        _equipmentCreateService = equipmentCreateService;
        _equipmentUpdateService = equipmentUpdateService;
    }
    [HttpGet]
    [Route("{equipmentId}")]
    public async Task<IActionResult> GetEquipment(string equipmentId)
    {
        var result = await _equipmentFetcherService.GetEquipmentByIdAsync(equipmentId);
        return result.Status == OperationStatus.Success ? Ok(result.Result) : NotFound(result.Message);
    }

    [HttpGet]
    public async Task<IActionResult> GetEquipments()
    {
        var result = await _equipmentFetcherService.GetAllEquipmentsAsync();
        return result.Status == OperationStatus.Success ? Ok(result.Result) : new EmptyResult();
    }

    [HttpPost]
    [Route("Create")]
    public async Task<IActionResult> CreateEquipment([FromBody] EquipmentEntity equipment)
    {
        var result = await _equipmentCreateService.CreateEquipmentAsync(equipment);
        return result.Status == OperationStatus.Success ? Ok(result.Result) : BadRequest(result.Message);
    }

    [HttpPost]
    [Route("CreateMany")]
    public async Task<IActionResult> CreateMultipleEquipments([FromBody] List<EquipmentEntity> equipmentList)
    {
        var result = await _equipmentCreateService.CreateMultipleEquipmentAsync(equipmentList);
        return result.Status == OperationStatus.Success ? Ok(result.Result) : BadRequest(result.Message);
    }

    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> UpdateEquipment([FromBody] EquipmentEntity equipment)
    {
        var result = await _equipmentUpdateService.UpdateEquipmentAsync(equipment);
        return result.Status == OperationStatus.Success ? Ok(result.Result) : BadRequest(result.Message);
    }
}