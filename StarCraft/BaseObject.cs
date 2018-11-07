namespace StarCraft
{
    public abstract class BaseObject
    {
        public BaseObject(string objectName, int hitPoints, int armorPoints, int constructionTime)
        {
            ObjectName = objectName;
            HitPoints = hitPoints;
            ArmorPoints = armorPoints;
            ConstructionTime = constructionTime;
        }

        public string ObjectName { get; set; }

        public int HitPoints { get; set; }

        public int ArmorPoints { get; set; }

        public int ConstructionTime { get; set; }
    }
}