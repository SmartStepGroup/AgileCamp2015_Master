using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class HabitModel
    {
        private readonly IDate date;

        private HabitModel() {}

        public HabitModel(IDate date)
        {
            this.date = date;
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

        public void UpdateStatus()
        {
            if (Count > 0)
            {
                Status = HabitStatus.InProgress;
                return;
            }

            if (Count >= 21)
            {
                Status = HabitStatus.Completed;
                Completed();
                return;
            }
        }

        private void Completed()
        {
            if (OnCompleted != null) OnCompleted(this, EventArgs.Empty);
        }

        public event EventHandler OnCompleted;

        public void IncrementCount()
        {
            Count++;
            UpdateStatus();
        }
    }

    public enum HabitStatus {
        New,
        Completed,
        InProgress
    }
}