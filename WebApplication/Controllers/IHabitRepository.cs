using System;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public interface IHabitRepository : IDisposable {
        IQueryable<Habit> ReadHabits();
    }
}