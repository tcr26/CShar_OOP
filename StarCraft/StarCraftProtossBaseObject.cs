using StarCraft.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarCraft
{
    public abstract class ProtossBaseObject : BaseUnitAdvanced
    {
        public ProtossBaseObject(string objectName, int hp, int armorPoints, int construction, int shield, int attackPoints, int attackRange, int attackSpeed, int manaPoints, string rank, int movementSpeed)
            : base(attackPoints, attackRange, attackSpeed, manaPoints, objectName, hp, armorPoints, construction, shield, rank, movementSpeed)
        {
            Shield = shield;
        }

        public int Shield { get; protected set; }

        public virtual bool propertyCheck(dynamic objectName, string prop)
        {
            return objectName.GetType().GetProperty(prop) != null;
        }
    }
}
