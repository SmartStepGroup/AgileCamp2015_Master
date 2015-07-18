#region Usings

using NUnit.Framework;
using WebApplication.Controllers;

#endregion

namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var controller = new HabitController();
            Assert.True(true);
        }
    }
}