#region Usings

using System.Linq;
using System.Web.Mvc;
using WebApplication.Models;

#endregion

namespace WebApplication.Controllers
{
    public class UsersByHabitController : Controller
    {
        private readonly ApplicationDbContext context = ApplicationDbContext.Create();

        public ActionResult Index(int id)
        {
            var habit = context.Habits.Single(_ => _.Id == id);
            var model = new HabitService(context).GetUsers(habit.Name);
            return View(model);
        }
    }
}