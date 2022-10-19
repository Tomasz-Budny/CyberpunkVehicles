namespace CyberpunkVehicles.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string ImageRelativePath { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int HorsePower { get; set; }
        public string TopSpeed { get; set; }
        public int Year { get; set; }
        
        public int DrivetrainId { get; set; }
        public int BodyId { get; set; }
        public virtual Drivetrain Drivetrain { get; set; }
        public virtual Body Body { get; set; }
    }
}