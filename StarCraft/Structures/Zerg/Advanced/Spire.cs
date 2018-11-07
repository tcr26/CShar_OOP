namespace StarCraft.Structures.Zerg.Advanced
{
    public class Spire : BaseObject, IZergBaseObject
    {
        public Spire()
            : base("Spire", 750, 1, 85)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}