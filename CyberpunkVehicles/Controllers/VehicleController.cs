﻿using CyberpunkVehicles.Services;
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
        
    }
}