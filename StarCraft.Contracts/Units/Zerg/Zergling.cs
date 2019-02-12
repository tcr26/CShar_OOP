namespace StarCraft.Units.Zerg
{
    public class Zergling : BaseUnitAdvanced, IAttackObject, IZergBaseObject
    {
        public Zergling() : base("Zerling", 25, 0, 20, 2, "Bug")

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