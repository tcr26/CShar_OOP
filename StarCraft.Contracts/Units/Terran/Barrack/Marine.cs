using StarCraft.Contracts;
using StarCraft.Contracts.Interfaces;

namespace StarCraft.Units.Terran.Barrack
{
    public class Marine : BaseObject, IAttackObject, IAttacking, IBaseUnitAdvanced
    {
        public Marine()
            : base("Marine", 45, 0, 20, "Light", "Biological")
        {
            AttackPower = 5;
            AttackRange = 6;
            AttackRate = 1.7F;
            MovementSpeed = 1;
            Rank = "Private";
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

            do
            {
                unitToBeAttacked.HitPoints -= (AttackPower - unitToBeAttacked.ArmorPoints);
            } while (unitToBeAttacked.HitPoints >= 0);
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