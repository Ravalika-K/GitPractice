using System.ComponentModel.DataAnnotations;

namespace Employee_MVC_App.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name must be entered")]
        [MaxLength(7,ErrorMessage = "exceeding")]
        [MinLength(2,ErrorMessage ="less")]
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
        public int PhnNo { get; set; }

    }
}
