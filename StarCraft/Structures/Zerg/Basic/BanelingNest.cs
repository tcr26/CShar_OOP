namespace StarCraft.Structures.Zerg.Basic
{
    public class BanelingNest : BaseObject, IZergBaseObject
    {
        public BanelingNest()
            : base("Baneling Nest", 750, 1, 55)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}