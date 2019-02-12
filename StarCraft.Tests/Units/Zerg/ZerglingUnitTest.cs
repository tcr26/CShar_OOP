using NUnit.Framework;
using StarCraft.Contracts.Interfaces;
using StarCraft.Units.Zerg.SpawningPool;

namespace StarCraft.Tests.Units.Zerg
{
    [TestFixture]
    public class ZerglingUnitTest
    {
        private Zergling Zerglings { get; set; }

        public ZerglingUnitTest()
        {
            Zerglings = new Zergling();
        }

        [Test]
        public void ZerglignAttackProperties()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5, Zerglings.AttackPower);
                Assert.AreEqual(1, Zerglings.AttackRange);
                Assert.AreEqual(1, Zerglings.AttackRate);
            });
        }

        [Test]
        public void ZerglingAttributes()
        {
            string[] zerglingAttributes =
            {
                "Light", "Biological"
            };

            CollectionAssert.AreEquivalent(zerglingAttributes, Zerglings.Attributes, "Zerglings must have attributes");
        }

        [Test]
        public void ZerglingHealthRegeneration()
        {
            Assert.AreEqual(2, Zerglings.HitPointsRegenerateRate, "Zergling have regeneration");
        }

        [Test]
        public void ZerglingImplementIZergHealthRegenartion()
        {
            var expcted = Zerglings is IZergHealthRegeneration;

            Assert.True(expcted, "Zergling regenerate health points over time");
        }

        [Test]
        public void ZerglingImplementIAttackObject()
        {
            var expected = Zerglings is IAttackObject;

            Assert.True(expected, "Zergling can attack");
        }

        [Test]
        public void ZerglingNotImplementIManaPoints()
        {
            var expected = Zerglings is IManaPoints;

            Assert.False(expected, "Zergling doesnt have Mana Points");
        }
    }
}