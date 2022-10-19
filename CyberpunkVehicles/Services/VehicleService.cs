using System.Collections.Generic;
using AutoMapper;
using CyberpunkVehicles.Entities;
using CyberpunkVehicles.Models;
using Microsoft.EntityFrameworkCore;

namespace CyberpunkVehicles.Services
{
    public interface IVehicleService
    {
        IEnumerable<VehicleDto> GetAll();
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
        
        public IEnumerable<VehicleDto> GetAll()
        {
            var vehiclesDto = _mapper.Map<IEnumerable<VehicleDto>>(
                _dbContext
                    .Vehicles
                    .Include(v => v.Body)
                    .Include(v => v.Drivetrain));
            return vehiclesDto;
        }
    }
}