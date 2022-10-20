using AutoMapper;
using CyberpunkVehicles.Entities;
using CyberpunkVehicles.Models;
using CyberpunkVehicles.Services;

namespace CyberpunkVehicles
{
    public class VehicleMappingProfile: Profile
    {
        public VehicleMappingProfile()
        {
            CreateMap<Vehicle, VehicleDto>()
                .ForMember(m => m.Drivetrain,
                    c =>
                        c.MapFrom(s => s.Drivetrain.Type))
                .ForMember(m => m.Body,
                    c =>
                        c.MapFrom(s => s.Body.Type));
            
            CreateMap<CreateVehicleDto, Vehicle>()
                .ForMember(m => m.ImageRelativePath,
                    c =>
                        c.MapFrom(s => $"Images/{s.Name}.png"))
                .ForMember(m => m.TopSpeed,
                    c =>
                        c.MapFrom(s => $"{s.TopSpeed} MPH"));

            CreateMap<UpdateVehicleDto, Vehicle>();
        }
    }
}