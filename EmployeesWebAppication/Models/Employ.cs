using System.ComponentModel.DataAnnotations;

namespace EmployeesWebAppication.Models

{
    public class Employ
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Employ Name")]
        public string Emp_name {get; set;}

        [Display(Name = "Job Title")]
        
        public string Emp_JobTitle { get; set; }

    }
}
