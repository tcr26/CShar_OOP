using StarCraft.Contracts;
using StarCraft.Contracts.Interfaces;

namespace StarCraft.Units.Zerg.SpawningPool
{
    public class Zergling : BaseObject, IAttackObject, IAttacking, IZergHealthRegeneration, IBaseUnitAdvanced
    {
        public Zergling()
            : base("Zerling", 35, 0, 20, "Light", "Biological")

        {
            AttackPower = 5;
            AttackRange = 1;
            AttackRate = 1;
            HitPointsRegenerateRate = 2;
            MovementSpeed = 2;
            Rank = "Predator";
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public int HitPointsRegenerateRate { get; set; }

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