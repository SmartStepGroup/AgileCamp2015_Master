#region Usings

using Moq;
using NUnit.Framework;
using WebApplication.Models;

#endregion

namespace UnitTests
{
    [TestFixture]
    public class HabitModelTest
    {
        [Test]
        public void ByDefault_HabitStatusIs_New()
        {
            HabitModel habit;

            habit = new HabitModel(null);

            Assert.AreEqual(HabitStatus.New, habit.Status);
        }

        [Test]
        public void Completed()
        {
            var habit = new HabitModel(null);
            var completedWasFired = false;
            habit.OnCompleted += (_, __) => completedWasFired = true;

            for (var i = 1; i <= 20; i++) habit.IncrementCount();
            Assert.IsFalse(completedWasFired);

            habit.IncrementCount();
            Assert.IsFalse(completedWasFired);
        }
    }
}