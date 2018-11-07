namespace StarCraft.Structures.Zerg.Basic
{
    public class SporeCrawler : BaseObject, IZergBaseObject, IAttackObject
    {
        public SporeCrawler()
            : base("Spore Crawler", 450, 1, 35)
        {
            AttackPower = 7;
            AttackRange = 1;
            AttackRate = 1;
            HitPointsRegenerateRate = 2;
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public int HitPointsRegenerateRate { get; set; }
    }
}