namespace StarCraft.Units.Terran
{
    public class Marine : BaseUnit, IAttackObject
    {
        public Marine() : base("Marine", 45, 0, 20)
        {
            AttackPower = 5;
            AttackRange = 6;
            AttackRate = 1.7F;
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }
    }
}