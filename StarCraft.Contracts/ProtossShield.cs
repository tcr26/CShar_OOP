namespace StarCraft.Contracts
{
    public class ProtossShield : BaseObject
    {
        public ProtossShield(string objectName, int hitPoints, int armorPoints, int constructionTime, int shield, int shieldArmor, params string[] attributes)
            : base(objectName, hitPoints, armorPoints, constructionTime, attributes)
        {
            Shield = shield;
            ShieldArmor = shieldArmor;
        }

        public int Shield { get; set; }

        public int ShieldArmor { get; set; }
    }
}