namespace StarCraft.Units
{
    public class BaseUnitAdvanced : BaseUnit
    {
        public BaseUnitAdvanced(string objectName, int hitPoints, int armorPoints, int constructionTime, int movementSpeed, string rank) : base(objectName, hitPoints, armorPoints, constructionTime)
        {
            MovementSpeed = movementSpeed;
            Rank = rank;
        }

        public int MovementSpeed { get; set; }

        public string Rank { get; set; }
    }
}