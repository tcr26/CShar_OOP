using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft.Units
{
    public abstract class BaseUnitAdvanced : BaseUnit
    {
        public BaseUnitAdvanced(int attackPoints, int attackRange, int attackSpeed, int manaPoints, string objectName, int hp, int armorPoints, int construction, int shield, string rank, int movementSpeed)
            : base(objectName, hp, armorPoints, construction, rank, movementSpeed)
        {
            ManaPoints = manaPoints;
            AttackRange = attackRange;
            AttackPoints = attackPoints;
            AttackSpeed = attackSpeed;
        }

        public int ManaPoints { get; set; }
        public double AttackRange { get; set; }
        public int AttackPoints { get; set; }
        public double AttackSpeed { get; set; }

        public virtual void Attack(BaseUnit unitToAttack)
        {
            Console.WriteLine("Attacking {0}", unitToAttack.UnitName);
            unitToAttack.HitPoints -= (AttackPoints - unitToAttack.ArmorPoints);
            Console.WriteLine("HitPoints left after the attack...{0}", unitToAttack.HitPoints);
        }
    }
}
