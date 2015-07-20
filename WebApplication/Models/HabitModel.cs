using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class HabitModel
    {
        public HabitModel()
        {
            Count = 0;
            Status = HabitStatus.New;
        }


        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Count")]
        public int Count { get; private set; }

        public HabitStatus Status { get; set; }

        public string UserEmail { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Count);
        }
    }

    public enum HabitStatus {
        New
    }
}