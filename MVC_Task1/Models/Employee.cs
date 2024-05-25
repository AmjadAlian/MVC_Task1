using System.ComponentModel.DataAnnotations;

namespace MVC_Task1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string title { get; set; } = null!;

        [Required]
        public int Age { get; set; }
    }
}
