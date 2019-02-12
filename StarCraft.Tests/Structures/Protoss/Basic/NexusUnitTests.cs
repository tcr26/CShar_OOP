using NUnit.Framework;
using StarCraft.Contracts;
using StarCraft.Contracts.Interfaces;
using StarCraft.Contracts.Structures.Protoss.Basic;

namespace StarCraft.Tests.Structures.Protoss.Basic
{
    [TestFixture]
    public class NexusUnitTests
    {
        private Nexus Nexuses { get; set; }

        public NexusUnitTests()
        {
            Nexuses = new Nexus();
        }

        [Test]
        public void NexusShield()
        {
            Assert.AreEqual(200, Nexuses.Shield, "Nexus Shield is 200");
        }

        [Test]
        public void NexusShieldArmor()
        {
            Assert.AreEqual(2, Nexuses.ShieldArmor);
        }

        [Test]
        public void NexusManaPoints()
        {
            Assert.AreEqual(200, Nexuses.ManaPoints, "Nexus Mana Points is 200");
        }

        [Test]
        public void NexusAttributes()
        {
            string[] nexusAttributes =
            {
                "Armored", "Structure"
            };

            CollectionAssert.AreEquivalent(nexusAttributes, Nexuses.Attributes);
        }

        [Test]
        public void NexusImplementIProtossShield()
        {
            var expected = Nexuses is ProtossShield;

            Assert.True(expected, "Nexus is a Protoss structure");
        }

        [Test]
        public void NexusImplementIManaPoints()
        {
            var expected = Nexuses is IManaPoints;

            Assert.True(expected, "Nexus have Mana Points");
        }

        [Test]
        public void NexusNotImplementIAttackObject()
        {
            var expected = Nexuses is IAttackObject;

            Assert.False(expected, "Nexus cannot attack");
        }

        [Test]
        public void NexusNotImplementIZergHealtRegenartion()
        {
            var expected = Nexuses is IZergHealthRegeneration;

            Assert.False(expected, "Nexus is not a Zerg structure");
        }
    }
}