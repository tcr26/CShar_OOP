namespace StarCraft.Structures.Zerg.Basic
{
    public class Hatchery : BaseObject, IZergBaseObject
    {
        public Hatchery()
            : base("Hatchery", 1500, 1, 80)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}