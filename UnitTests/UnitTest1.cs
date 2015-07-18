#region Usings

using NUnit.Framework;
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
            var habit = new Habit {Name = "Habit", Count = 1};

            Assert.AreEqual("Habit", habit.Name);
        }
    }
}