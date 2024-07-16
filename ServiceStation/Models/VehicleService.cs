namespace ServiceStation.Models
{
    public class VehicleService
    {

        public VehicleService() { }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public bool IsDelete { get; set; }

    }
}
