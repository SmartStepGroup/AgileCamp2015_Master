using System.Linq;
using WebApplication.Controllers;
using WebApplication.Models;

namespace WebApplication.Infrastructure
{
    public class HabitRepository : IHabitRepository
    {
        private ApplicationDbContext context = ApplicationDbContext.Create();

        public IQueryable<Habit> ReadHabits()
        {
            return context.Habits;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }
    }
}