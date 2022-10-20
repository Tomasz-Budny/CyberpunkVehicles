namespace CyberpunkVehicles.Models
{
    public class UpdateVehicleDto
    {
        public int DrivetrainId { get; set; }
        public int BodyId { get; set; }
        public int Weight { get; set; }
        public int HorsePower { get; set; }
        public int TopSpeed { get; set; }
        public int Year { get; set; }
    }
}