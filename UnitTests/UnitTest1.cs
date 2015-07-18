#region Usings

using System.Linq;
using System.Web.Mvc;
using NUnit.Framework;
using WebApplication.Controllers;
using WebApplication.Models;

#endregion

namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var formCollection = new FormCollection();
            formCollection["Name"] = "Habit";

            var habitController = new HabitController();
            habitController.Create(formCollection);

            var habit = ApplicationDbContext.Create().Habits.Single();
            Assert.AreEqual("Habit", habit.Name);
        }
    }
}