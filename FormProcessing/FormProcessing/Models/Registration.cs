using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace FormProcessing.Models
{
    public class Registration
    {
        [Required(ErrorMessage ="Please provide name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(10,MinimumLength =3)]
        public string Uname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Required]
        [Range(1,40)]
        public int Roll { get; set; }
    }
}
