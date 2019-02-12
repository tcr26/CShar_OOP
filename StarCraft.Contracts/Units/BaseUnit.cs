namespace StarCraft.Units
{
    public abstract class BaseUnit : BaseObject
    {
        public BaseUnit(string objectName, int hitPoints, int armorPoints, int constructionTime, params string[] attributes)
            : base(objectName, hitPoints, armorPoints, constructionTime, attributes)
        {
        }
    }
}