using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StarCraft;

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

        public static bool propertyCheck(dynamic objectName, string prop)
        {
            return objectName.GetType().GetProperty(prop) != null;
        }

        public virtual void AttackShield(ProtossBaseObject objectShield, StarCraftBaseObject objectHitPoints)
        {
            if (propertyCheck(objectShield, "Shield"))
            {
                while (objectShield.Shield >= 0)
                {
                    Console.WriteLine("Attacking {0} with {1} Shield", objectShield.ObjectName, objectShield.Shield);
                    objectShield.Shield -= (AttackPoints - objectShield.ArmorPoints);
                    Console.WriteLine("Shield left after the attack...{0}", objectShield.Shield);
                    Console.ReadKey();
                }
                while (objectHitPoints.HitPoints >= 0)
                {
                    Console.WriteLine("Attacking {0} with {1} HitPoints", objectHitPoints.ObjectName, objectHitPoints.HitPoints);
                    objectHitPoints.HitPoints -= (AttackPoints - objectHitPoints.ArmorPoints);
                    Console.WriteLine("HitPoints left after the attack...{0}", objectHitPoints.HitPoints);
                    Console.ReadKey();
                }
            }
        }

        public virtual void AttackHitPoints(StarCraftBaseObject unitToAttack)
        {
            Console.WriteLine("Attacking {0} with {1} HitPoints", unitToAttack.ObjectName, unitToAttack.HitPoints);
            unitToAttack.HitPoints -= (AttackPoints - unitToAttack.ArmorPoints);
            Console.WriteLine("HitPoints left after the attack...{0}", unitToAttack.HitPoints);
            Console.ReadKey();
        }
    }
}
