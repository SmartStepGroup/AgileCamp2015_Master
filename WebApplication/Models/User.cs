using System.Collections;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public class User
    {
        public User(string name, string email, IEnumerable<HabitModel> habits)
        {
            Name = name;
            Email = email;
            Habits = habits;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public IEnumerable<HabitModel> Habits { get; private set; }
    }
}