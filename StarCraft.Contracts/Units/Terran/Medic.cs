namespace StarCraft.Units.Terran

{
    public class Medic : BaseUnit, IManaPoints
    {
        public Medic() : base("Medic", 55, 0, 35)
        {
            ManaPoints = 200;
        }

        public int ManaPoints { get; set; }
    }
}