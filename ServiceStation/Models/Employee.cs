namespace ServiceStation.Models
{
    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; }
    }
}
