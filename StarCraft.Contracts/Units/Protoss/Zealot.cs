namespace StarCraft.Units.Protoss
{
    public class Zealot : BaseUnitAdvanced, IProtossBaseObject
    {
        public Zealot() : base("Zealot", 75, 1, 30, 1, "Zelka")
        {
            AttackPower = 7;
            AttackRange = 1;
            AttackRate = 1.4F;
            Shield = 75;
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public int Shield { get; set; }
    }
}