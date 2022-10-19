using System.Collections.Generic;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public VehicleService(VehicleDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        
        
    }
}