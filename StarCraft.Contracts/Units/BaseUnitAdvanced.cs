namespace StarCraft.Units
{
    public abstract class BaseUnitAdvanced : BaseUnit
    {
        public BaseUnitAdvanced(string objectName, int hitPoints, int armorPoints, int constructionTime, int movementSpeed, string rank, params string[] attributes)
            : base(objectName, hitPoints, armorPoints, constructionTime, attributes)
        {
            MovementSpeed = movementSpeed;
            Rank = rank;
        }

        public int MovementSpeed { get; set; }

        public string Rank { get; set; }
    }
}