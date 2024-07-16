namespace ServiceStation.Models
{
    public class Vehicle
    {
        public Vehicle() { }
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public bool IsDeleted { get; set; }
        public int CustomerId { get; set; }

    }
}
