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
    private readonly IEquipmentCreateService _equipmentCreateService;
    private readonly IEquipmentUpdateService _equipmentUpdateService;
    public EquipmentsController(
        IEquipmentCreateService equipmentCreateService,
        IEquipmentUpdateService equipmentUpdateService)
    {
        _equipmentCreateService = equipmentCreateService;
        _equipmentUpdateService = equipmentUpdateService;
    }


    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> UpdateEquipment([FromBody] EquipmentEntity equipment)
    {
        var result = await _equipmentUpdateService.UpdateEquipmentAsync(equipment);
        return result.Status == OperationStatus.Success
            ? Ok(result.Message)
            : BadRequest(result.Message);
    }

    [HttpPut]
    [Route("UpdateMany")]
    public async Task<IActionResult> UpdateMultipleEquipment([FromBody] List<EquipmentEntity> equipmentList)
    {
        var result = await _equipmentUpdateService.UpdateEquipmentMulitpleAsync(equipmentList);
        return result.Status == OperationStatus.Success
            ? Ok(result.Message)
            : BadRequest(result.Message);
    }
}