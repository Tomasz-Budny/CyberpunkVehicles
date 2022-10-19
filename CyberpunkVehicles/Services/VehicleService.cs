using System.Collections.Generic;
using CyberpunkVehicles.Entities;
using CyberpunkVehicles.Models;

namespace CyberpunkVehicles.Services
{
    public interface IVehicleService
    {
        
    }
    
    public class VehicleService: IVehicleService
    {
        private readonly VehicleDbContext _dbContext;
        public VehicleService(VehicleDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        
    }
}