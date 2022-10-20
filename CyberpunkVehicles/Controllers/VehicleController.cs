using CyberpunkVehicles.Models;
using CyberpunkVehicles.Services;
using Microsoft.AspNetCore.Mvc;

namespace CyberpunkVehicles.Controllers
{
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController: ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        
        [HttpGet]
        public ActionResult Get()
        {
            var vehiclesDto = _vehicleService.GetAll();
            return Ok(vehiclesDto);
        }
        
        [HttpPost]
        public ActionResult Post([FromForm]CreateVehicleDto dto)
        {
            var result = _vehicleService.Create(dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _vehicleService.DeleteVehicle(id);
            return NoContent();
        }
        
    }
}