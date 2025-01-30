using System.ComponentModel.DataAnnotations;

namespace SuperSimplreProject.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public required ICollection<Employee> Employees { get; set; }
    }

}
