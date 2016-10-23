using System;
using System.Threading;

namespace StarCraft.Structures
{
    public abstract class BaseStructure
    {
        public BaseStructure(string name, int hitPoints, int armorPoints, int constructionTime)
        {
            Name = name;
            HitPoints = hitPoints;
            ArmorPoints = armorPoints;
            ConstructionTime = constructionTime;
        }

        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ArmorPoints { get; set; }
        public int ConstructionTime { get; set; }

        public virtual void Consturction(BaseStructure ConstuructBuilding)
        {
            Thread.Sleep((int)(1000 * ConstructionTime));
        }
    }
}