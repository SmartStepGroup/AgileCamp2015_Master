using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Habit
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Count")]
        public int Count { get; set; }

        public string UserEmail { get; set; }
    }
}