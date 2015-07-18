#region Usings

using System;
using System.Linq;
using System.Web.Mvc;
using WebApplication.Models;

#endregion

namespace WebApplication.Controllers
{
    public class HabitController : Controller
    {
        private readonly ApplicationDbContext context = ApplicationDbContext.Create();

        // GET: Habit
        public ActionResult Index()
        {
            var model = context.Habits.Where(_ => _.UserEmail == User.Identity.Name);
            return View(model);
        }

        // GET: Habit/Details/5
        public ActionResult Details(int id)
        {
            var model = context.Habits.SingleOrDefault(_ => _.Id == id);
            return View(model);
        }

        // GET: Habit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Habit/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                context.Habits.Add(new Habit
                {
                    Name = collection["Name"],
                    Count = 0,
                    UserEmail = User.Identity.Name
                });
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Habit/Edit/5
        public ActionResult Edit(int id)
        {
            var model = context.Habits.SingleOrDefault(_ => _.Id == id);
            return View(model);
        }

        // POST: Habit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var model = context.Habits.SingleOrDefault(_ => _.Id == id);
                model.Name = collection["Name"];
                model.Count = Convert.ToInt32(collection["Count"]);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Habit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Habit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var habit = context.Habits.SingleOrDefault(_ => _.Id == id);
                context.Habits.Remove(habit);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}