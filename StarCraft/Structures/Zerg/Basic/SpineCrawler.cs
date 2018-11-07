namespace StarCraft.Structures.Zerg.Basic
{
    public class SpineCrawler : BaseObject, IZergBaseObject, IAttackObject
    {
        public SpineCrawler()
            : base("Spine Crawler", 500, 1, 40)
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