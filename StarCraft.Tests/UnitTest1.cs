using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarCraft.Units.Terran.Barrack;

namespace StarCraft.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateDefaultMarine()
        {
            Marine marine = new Marine();
            Assert.AreEqual(45, marine.HitPoints, "Marine.HitPoints");
            Assert.AreEqual(0, marine.ArmorPoints, "Marine.ArmorPoints");
        }
    }
}