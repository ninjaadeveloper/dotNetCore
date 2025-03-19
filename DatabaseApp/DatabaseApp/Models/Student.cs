using System.ComponentModel.DataAnnotations;

namespace DatabaseApp.Models
{
    public class Student
    {
        [Key]
        public int sid { get; set; }

        [Required(ErrorMessage = "Name Lazmii dena ha")]
        [StringLength(10,MinimumLength =3)]
        public string sname{ get; set; }

        [Required]
        public string semail { get; set; }

        [Required]
        public string sbatch { get; set; }
    }
}
