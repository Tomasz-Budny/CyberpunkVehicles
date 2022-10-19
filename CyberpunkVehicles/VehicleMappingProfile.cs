using AutoMapper;
using CyberpunkVehicles.Entities;
using CyberpunkVehicles.Models;

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
        }
    }
}