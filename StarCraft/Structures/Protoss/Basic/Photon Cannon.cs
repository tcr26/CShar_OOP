namespace StarCraft.Structures.Protoss.Basic
{
    public class PhotonCannon : BaseObject, IProtossBaseObject, IAttackObject
    {
        public PhotonCannon() : base("Photon Cannon", 175, 1, 40)
        {
            AttackPower = 7;
            AttackRange = 6;
            AttackRate = 1.4F;
            Shield = 175;
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public int Shield { get; set; }
    }
}