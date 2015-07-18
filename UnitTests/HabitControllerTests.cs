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
        public void Index()
        {
            var repository = Mock.Of<IHabitRepository>(_ =>
                _.ReadHabits() == new[] {new Habit {Name = "Habit1", Count = 1, UserEmail = "user@email.com"}}.AsQueryable());
            var habitController = new HabitController(repository) {UserEmail = "user@email.com"};

            var view = habitController.Index();

            var habit = view.Model<IQueryable<Habit>>().Single();
            Assert.AreEqual("Habit1", habit.Name);
            Assert.AreEqual(1, habit.Count);
            Assert.AreEqual("user@email.com", habit.UserEmail);
        }
    }
}