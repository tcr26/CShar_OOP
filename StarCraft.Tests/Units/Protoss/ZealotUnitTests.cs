using NUnit.Framework;
using StarCraft.Contracts;
using StarCraft.Contracts.Interfaces;
using StarCraft.Units.Protoss.WarpGate;

namespace StarCraft.Tests.Units.Protoss
{
    [TestFixture]
    public class ZealotUnitTests
    {
        private Zealot Zealots { get; set; }

        public ZealotUnitTests()
        {
            Zealots = new Zealot();
        }

        [Test]
        public void ZealotAttackProperties()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(7, Zealots.AttackPower);
                Assert.AreEqual(1, Zealots.AttackRange);
                Assert.AreEqual(1.4F, Zealots.AttackRate);
            });
        }

        [Test]
        public void ZealotAttributes()
        {
            string[] zealotAttributes =
            {
                "Light", "Biological"
            };

            CollectionAssert.AreEquivalent(zealotAttributes, Zealots.Attributes);
        }

        [Test]
        public void ZealotShield()
        {
            Assert.AreEqual(75, Zealots.Shield);
        }

        [Test]
        public void ZealotShieldArmor()
        {
            Assert.AreEqual(0, Zealots.ShieldArmor);
        }

        [Test]
        public void ZealotImplementIProtossShield()
        {
            var expected = Zealots is ProtossShield;

            Assert.True(expected, "Zealot is Protoss");
        }

        [Test]
        public void ZealotImplementIAttackObject()
        {
            var expected = Zealots is IAttackObject;

            Assert.True(expected, "Zealot can attack");
        }

        [Test]
        public void ZealotNotImplementIManaPoints()
        {
            var expected = Zealots is IManaPoints;

            Assert.False(expected, "Zealot doesnt have mana points");
        }

        [Test]
        public void ZealotNotImplementIZergHealthRegeneration()
        {
            var expected = Zealots is IZergHealthRegeneration;

            Assert.False(expected, "Zealot is not Zerg");
        }
    }
}