using StarCraft.Units;
using System;

namespace StarCraft
{
    public abstract class ProtossBaseObject : BaseUnitAdvanced
    {
        public ProtossBaseObject(string objectName, int hp, int armorPoints, int construction, int shield, int attackPoints, int attackRange, int attackSpeed, int manaPoints, string rank, int movementSpeed)
            : base(attackPoints, attackRange, attackSpeed, manaPoints, objectName, hp, armorPoints, construction, shield, rank, movementSpeed)
        {
            Shield = shield;
        }

        public int Shield { get; set; }

        public virtual void shieldRegenaration(ProtossBaseObject objectName)
        {
            do
            {
                Console.WriteLine("Shield before:{0} ", objectName.Shield);
                objectName.Shield -= 10;
                Console.WriteLine("Shield after:{0}", objectName.Shield);
                objectName.Shield += 1;
                Console.WriteLine("Shield regend:{0}", objectName.Shield);
            } while (objectName.Shield >= 0);
        }
    }
}

//public static string GetAllProperties(object obj)
//{
//    return string.Join(" ", obj.GetType().GetProperties().Select(prop => prop.GetValue(obj)));
//}