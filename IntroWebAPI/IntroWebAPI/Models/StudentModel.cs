using System.ComponentModel.DataAnnotations;

namespace IntroWebAPI.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public double Cgpa { get; set; }
        [Required]
        public int DeptId { get; set; }
    }
}
