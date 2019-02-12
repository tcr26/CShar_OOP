using NUnit.Framework;
using StarCraft.Contracts.Interfaces;
using StarCraft.Units.Terran.Barrack;

namespace StarCraft.Tests.Units.Terran
{
    [TestFixture]
    public class MarineUnitTests
    {
        private Marine Marines { get; set; }

        public MarineUnitTests()
        {
            Marines = new Marine();
        }

        [Test]
        public void MarineAttackProperies()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5, Marines.AttackPower, "Marine must have attack power");
                Assert.AreEqual(6, Marines.AttackRange, "Marine must have attack range");
                Assert.AreEqual(1.7F, Marines.AttackRate, "Marine must have attack rate");
            });
        }

        [Test]
        public void MarineAttributes()
        {
            string[] marineAttributes =
            {
                "Light",
                "Biological"
            };

            CollectionAssert.AreEquivalent(marineAttributes, Marines.Attributes, "Marine must have attributes");
        }

        [Test]
        public void MarineImplementAttackInterface()
        {
            var expected = Marines is IAttackObject;

            Assert.True(expected, "Marine can attack");
        }

        [Test]
        public void MarineImplemenetIAttackingObject()
        {
            var expected = Marines is IAttacking;

            Assert.True(expected, "Marine must imeplement IAttacking");
        }

        [Test]
        public void MarineImeplementBaseUnitAdvanced()
        {
            var expected = Marines is IBaseUnitAdvanced;

            Assert.True(expected, "Marine must implement IBaseUnitAdvanced");
        }

        [Test]
        public void MarineNotImplementIManapoints()
        {
            var expceted = Marines is IManaPoints;

            Assert.False(expceted, "Marine doesnt have mana points");
        }

        [Test]
        public void MarineNotImplementIZergHealthregenartion()
        {
            var expected = Marines is IZergHealthRegeneration;

            Assert.False(expected, "Marine is not Zerg");
        }
    }
}