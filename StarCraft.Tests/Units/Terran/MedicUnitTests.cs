using NUnit.Framework;
using StarCraft.Contracts.Interfaces;
using StarCraft.Units.Terran.Barrack;

namespace StarCraft.Tests.Units.Terran
{
    [TestFixture]
    public class MedicUnitTests
    {
        private Medic Medics { get; set; }

        public MedicUnitTests()
        {
            Medics = new Medic();
        }

        [Test]
        public void MedicManaPoints()
        {
            Assert.AreEqual(200, Medics.ManaPoints);
        }

        [Test]
        public void MedicAttributes()
        {
            string[] medicAttributes =
            {
                "Light", "Biological"
            };

            CollectionAssert.AreEquivalent(medicAttributes, Medics.Attributes, "Medic must have attributes");
        }

        [Test]
        public void MedicImplementIManaPoints()
        {
            var expected = Medics is IManaPoints;

            Assert.True(expected, "Medic uses mana points on heal");
        }

        [Test]
        public void MedicNotImplementIAttackObject()
        {
            var expected = Medics is IAttackObject;

            Assert.False(expected, "Medic cannot attack");
        }

        [Test]
        public void MedicNotImplementIZergHealthRegeneration()
        {
            var expected = Medics is IZergHealthRegeneration;

            Assert.False(expected, "Medic is not Zerg");
        }
    }
}