using NUnit.Framework;
using StarCraft.Contracts.Interfaces;
using StarCraft.Contracts.Structures.Zerg.Basic;

namespace StarCraft.Tests.Structures.Zerg.Basic
{
    [TestFixture]
    public class HatcheryUnitTests
    {
        private Hatchery Hatcheries { get; set; }

        public HatcheryUnitTests()
        {
            Hatcheries = new Hatchery();
        }

        [Test]
        public void HatcheryAttributes()
        {
            string[] hatcheryAttrbitues =
            {
                "Armored", "Structure", "Biological"
            };

            CollectionAssert.AreEquivalent(hatcheryAttrbitues, Hatcheries.Attributes, "Hathcery must have attributes");
        }

        [Test]
        public void HatcheryImplementIZergHealthRegeneration()
        {
            var expected = Hatcheries is IZergHealthRegeneration;

            Assert.True(expected, "Hatchery is a Zerg structure");
        }

        [Test]
        public void HatcheryHealthRegeneration()
        {
            Assert.AreEqual(3, Hatcheries.HitPointsRegenerateRate);
        }

        [Test]
        public void HatcheryNotImplementIAttackObject()
        {
            var expected = Hatcheries is IAttackObject;

            Assert.False(expected, "Hatchery cannot attack");
        }

        [Test]
        public void HatcheryNotImplementIManaPoints()
        {
            var expected = Hatcheries is IManaPoints;

            Assert.False(expected, "Hatchery doesnt have Mana Points");
        }
    }
}