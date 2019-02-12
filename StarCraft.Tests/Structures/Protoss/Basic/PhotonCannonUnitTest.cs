using NUnit.Framework;
using StarCraft.Contracts;
using StarCraft.Contracts.Interfaces;
using StarCraft.Contracts.Structures.Protoss.Basic;

namespace StarCraft.Tests.Structures.Protoss.Basic
{
    [TestFixture]
    public class PhotonCannonUnitTest
    {
        private PhotonCannon PhotonCannons { get; set; }

        public PhotonCannonUnitTest()
        {
            PhotonCannons = new PhotonCannon();
        }

        [Test]
        public void PhotonCannonAttackProperties()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(7, PhotonCannons.AttackPower);
                Assert.AreEqual(6, PhotonCannons.AttackRange);
                Assert.AreEqual(1.4F, PhotonCannons.AttackRate);
            });
        }

        [Test]
        public void PhotonCannonShield()
        {
            Assert.AreEqual(175, PhotonCannons.Shield, "Photon Cannon is a Protoss strucutre");
        }

        [Test]
        public void PhotonCannonShieldArmor()
        {
            Assert.AreEqual(1, PhotonCannons.ShieldArmor);
        }

        [Test]
        public void PhotonCannonAttributes()
        {
            string[] photonCannonAttributes =
            {
                "Armored", "Structure"
            };

            CollectionAssert.AreEquivalent(photonCannonAttributes, PhotonCannons.Attributes);
        }

        [Test]
        public void PhotonCannonImplementIAttackObject()
        {
            var expected = PhotonCannons is IAttackObject;

            Assert.True(expected, "Photon Cannon can attack");
        }

        [Test]
        public void PhotonCannonImplementIProtossShield()
        {
            var expected = PhotonCannons is ProtossShield;

            Assert.True(expected, "Photon Cannon is a Protoss structure");
        }

        [Test]
        public void PhotonCannonNotImplementIManaPoints()
        {
            var expected = PhotonCannons is IManaPoints;

            Assert.False(expected, "Photon Cannon doesnt have mana points");
        }

        [Test]
        public void PhotonCannonNotImplementIZergHealthRegeneration()
        {
            var expected = PhotonCannons is IZergHealthRegeneration;

            Assert.False(expected, "Photon Cannon is not a Zerg structure");
        }
    }
}