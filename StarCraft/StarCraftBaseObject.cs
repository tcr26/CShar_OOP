using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    public abstract class StarCraftBaseObject
    {
        public StarCraftBaseObject(string objectName, int hitPoints, int armorPoints, int timeToConstruct)
        {
            ObjectName = objectName;
            HitPoints = hitPoints;
            ArmorPoints = armorPoints;
            TimeToConstruct = timeToConstruct;
        }

        public string ObjectName { get; set; }
        public int HitPoints { get; set; }
        public int ArmorPoints { get; set; }
        public int TimeToConstruct { get; set; }

    }
}
