namespace StarCraft.Structures.Zerg.Advanced
{
    public class LurkerDen : BaseObject, IZergBaseObject
    {
        public LurkerDen()
            : base("Lurker Den", 550, 1, 70)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}