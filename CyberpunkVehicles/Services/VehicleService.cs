﻿using System.Collections.Generic;
using System.IO;
using AutoMapper;
using CyberpunkVehicles.Entities;
using CyberpunkVehicles.Models;
using Microsoft.EntityFrameworkCore;

namespace CyberpunkVehicles.Services
{
    public interface IVehicleService
    {
        IEnumerable<VehicleDto> GetAll();
        bool Create(CreateVehicleDto dto);
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
        
        public bool Create(CreateVehicleDto dto)
        {
            var file = dto.VehicleImage;
            if (file != null && file.Length > 0)
            {
                var vehicle = _mapper.Map<Vehicle>(dto);
                _dbContext.Add(vehicle);
                _dbContext.SaveChanges();
                
                var rootPath = Directory.GetCurrentDirectory();
                var fullPath = $"{rootPath}/wwwroot/Images/{dto.Name}.png";

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return true;
            }
            return false;
        }
        
    }
    
    
}