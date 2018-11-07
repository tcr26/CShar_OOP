namespace StarCraft.Structures.Zerg.Advanced
{
    public class HydraliskDen : BaseObject, IZergBaseObject
    {
        public HydraliskDen()
            : base("Hydralisk Den", 450, 1, 55)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}