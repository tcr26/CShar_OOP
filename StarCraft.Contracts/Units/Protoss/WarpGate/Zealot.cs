using StarCraft.Contracts;
using StarCraft.Contracts.Interfaces;

namespace StarCraft.Units.Protoss.WarpGate
{
    public class Zealot : ProtossShield, IAttackObject, IAttacking, IBaseUnitAdvanced
    {
        public Zealot()
            : base("Zealot", 75, 1, 30, 75, 0, "Light", "Biological")
        {
            AttackPower = 7;
            AttackRange = 1;
            AttackRate = 1.4F;
            MovementSpeed = 1;
            Rank = "Zelka";
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public int MovementSpeed { get; set; }

        public string Rank { get; set; }

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