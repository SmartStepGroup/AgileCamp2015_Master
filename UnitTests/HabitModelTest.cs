#region Usings

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

            habit = new HabitModel();

            Assert.AreEqual(HabitStatus.New, habit.Status);
        }
    }
}