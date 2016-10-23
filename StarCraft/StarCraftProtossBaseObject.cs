using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarCraft
{
    public abstract class ProtossBaseObject : StarCraftBaseObject
    {
        public ProtossBaseObject(string objectName, int hp, int armorPoints, int construction, int shield)
            : base(objectName, hp, armorPoints, construction)
        {
            Shield = shield;
        }

        public int Shield { get; set; }

        public virtual void shieldRegeneration(ProtossBaseObject objectName)
        {
            if (objectName.Shield == objectName.Shield)
            {
                objectName.Shield = 4;
                Console.WriteLine(objectName.Shield);
                objectName.Shield += 10;
                Console.WriteLine(objectName.Shield);
            }
        }
        public virtual bool propertyCheck(dynamic objectName, string prop)
        {
            return objectName.GetType().GetProperty(prop) != null;
        }
    }
}
