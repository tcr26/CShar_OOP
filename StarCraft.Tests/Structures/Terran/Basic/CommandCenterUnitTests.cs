using NUnit.Framework;
using StarCraft.Contracts.Interfaces;
using StarCraft.Contracts.Structures.Terran.Basic;

namespace StarCraft.Tests.Structures.Terran.Basic
{
    [TestFixture]
    public class CommandCenterUnitTests
    {
        private CommandCenter CommandCenters { get; set; }

        public CommandCenterUnitTests()
        {
            CommandCenters = new CommandCenter();
        }

        [Test]
        public void CommandCenterAttributes()
        {
            string[] expected =
            {
                "Mechanical", "Structure"
            };

            CollectionAssert.AreEquivalent(expected, CommandCenters.Attributes, "Command Center must have attributes");
        }

        [Test]
        public void CommandCenterManaPoints()
        {
            Assert.AreEqual(200, CommandCenters.ManaPoints, "Command Center have Mana Points");
        }

        [Test]
        public void CommandCenterImplementIManaPoints()
        {
            var expected = CommandCenters is IManaPoints;

            Assert.True(expected, "Command Center have mana points");
        }

        [Test]
        public void CommandCenterNotImplementAttackObject()
        {
            var expected = CommandCenters is IAttackObject;

            Assert.False(expected, "Command Center cannot attack");
        }

        [Test]
        public void CommandCenterNotImplementIZergHealthRegeneration()
        {
            var expected = CommandCenters is IZergHealthRegeneration;

            Assert.False(expected, "Command Center its not a Zerg structure");
        }
    }
}