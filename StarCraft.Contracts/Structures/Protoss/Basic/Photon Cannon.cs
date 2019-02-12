using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Protoss.Basic
{
    public class PhotonCannon : ProtossShield, IAttackObject, IAttacking
    {
        public PhotonCannon()
            : base("Photon Cannon", 175, 1, 40, 175, 1, "Armored", "Structure")
        {
            AttackPower = 7;
            AttackRange = 6;
            AttackRate = 1.4F;
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public void AttackingProtossObject(ProtossShield unitToBeAttacked)
        {
            do
            {
                unitToBeAttacked.Shield -= (AttackPower - unitToBeAttacked.ShieldArmor);
            } while (unitToBeAttacked.Shield >= 0);

            if (unitToBeAttacked.Shield <= 0)
            {
                do
                {
                    unitToBeAttacked.HitPoints -= (AttackPower - unitToBeAttacked.ArmorPoints);
                } while (unitToBeAttacked.HitPoints >= 0);
            }
        }

        public void AttackinObject(BaseObject unitToBeAttacked)
        {
            do
            {
                unitToBeAttacked.HitPoints -= (AttackPower - unitToBeAttacked.ArmorPoints);
            } while (unitToBeAttacked.HitPoints >= 0);
        }
    }
}