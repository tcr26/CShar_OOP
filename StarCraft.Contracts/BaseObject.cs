using System.Collections.Generic;

namespace StarCraft
{
    public abstract class BaseObject
    {
        public BaseObject(string objectName, int hitPoints, int armorPoints, int constructionTime, params string[] attributes)
        {
            ObjectName = objectName;
            HitPoints = hitPoints;
            ArmorPoints = armorPoints;
            ConstructionTime = constructionTime;
            Attributes = attributes;
        }

        public int Id { get; set; }

        public string ObjectName { get; set; }

        public int HitPoints { get; set; }

        public int ArmorPoints { get; set; }

        public int ConstructionTime { get; set; }

        public IList<string> Attributes { get; set; }
    }
}