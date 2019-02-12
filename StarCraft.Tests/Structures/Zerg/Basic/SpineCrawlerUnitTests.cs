using NUnit.Framework;
using StarCraft.Contracts.Interfaces;
using StarCraft.Contracts.Structures.Zerg.Basic;

namespace StarCraft.Tests.Structures.Zerg.Basic
{
    [TestFixture]
    public class SpineCrawlerUnitTests
    {
        private SpineCrawler SpineCrawlers { get; set; }

        public SpineCrawlerUnitTests()
        {
            SpineCrawlers = new SpineCrawler();
        }

        [Test]
        public void SpineCrawlerHealthRegenerationRate()
        {
            Assert.AreEqual(2, SpineCrawlers.HitPointsRegenerateRate);
        }

        [Test]
        public void SpineCrawlerAttackProperties()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(7, SpineCrawlers.AttackPower);
                Assert.AreEqual(1, SpineCrawlers.AttackRange);
                Assert.AreEqual(1, SpineCrawlers.AttackRate);
            });
        }

        [Test]
        public void SpineCrawlerAttributes()
        {
            string[] spineCrawlerAttributes =
            {
                "Armored", "Structure", "Biological"
            };

            CollectionAssert.AreEquivalent(spineCrawlerAttributes, SpineCrawlers.Attributes);
        }

        [Test]
        public void SpineCrawlerImplementIAttackObject()
        {
            var expected = SpineCrawlers is IAttackObject;

            Assert.True(expected, "Spine Crawler can attack");
        }

        [Test]
        public void SpineCrawlerImplementAttackObject()
        {
            var expected = SpineCrawlers is IZergHealthRegeneration;

            Assert.True(expected, "Spine Crawler is a Zerg structure");
        }

        [Test]
        public void SpineCrawlerNotImplementIManaPoints()
        {
            var expected = SpineCrawlers is IManaPoints;

            Assert.False(expected, "Spine Crawler doesnt have mana points");
        }
    }
}