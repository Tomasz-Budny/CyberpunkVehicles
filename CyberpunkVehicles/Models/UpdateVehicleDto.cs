namespace CyberpunkVehicles.Models
{
    public class UpdateVehicleDto
    {
        public string Drivetrain { get; set; }
        public string Body { get; set; }
        public int Weight { get; set; }
        public int HorsePower { get; set; }
        public string TopSpeed { get; set; }
        public int Year { get; set; }
    }
}