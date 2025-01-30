namespace SuperSimplreProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }
    }
}
