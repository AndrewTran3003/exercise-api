using Microsoft.AspNetCore.Mvc;

[ApiController]
public class EquipmentsController : ControllerBase{
    [HttpGet]
    [Route("Equipments/{equipmentId}")]
    public IActionResult GetEquipment(string equipmentId){
        return Ok("Get one equipment");
    }

    [HttpGet]
    [Route("Equipments")]
    public IActionResult GetEquipments(){
        return Ok("Get many equipments");
    }
}