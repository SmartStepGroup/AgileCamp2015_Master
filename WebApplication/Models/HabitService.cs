using System.Collections.Generic;
using System.Linq;

namespace WebApplication.Models
{
    public class HabitService
    {
        private readonly IDbContext context;

        public HabitService(IDbContext context)
        {
            this.context = context;
        }

        public List<User> GetUsers(string habitName)
        {
            var userEmails = context.Habits.Where(_ => _.Name == habitName).Select(_ => _.UserEmail).ToList();
            return context.Users.Where(_ => userEmails.Contains(_.Email)).ToList();
        }
    }
}