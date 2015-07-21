#region Usings

using System.Linq;
using Moq;
using NUnit.Framework;
using WebApplication.Controllers;
using WebApplication.Models;

#endregion

namespace UnitTests
{
    [TestFixture]
    public class HabitControllerTests
    {
        [Test]
        [Ignore]
        public void Index()
        {
            var repository = Mock.Of<IHabitRepository>(_ => 
                _.ReadHabits() == new [] { new HabitModel(null) {Name = "Habit1", UserEmail = "user@email.com"}}.AsQueryable());
            var habitController = new HabitController(null);

            var view = habitController.Index();

            var habit = view.Model<IQueryable<HabitModel>>().Single();
            Assert.AreEqual("Habit1", habit.Name);
            Assert.AreEqual("user@email.com", habit.UserEmail);
        }
    }
}