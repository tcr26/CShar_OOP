namespace StarCraft.Structures.Zerg.Basic
{
    public class RoachWarren : BaseObject, IZergBaseObject
    {
        public RoachWarren()
            : base("Roach Warren", 650, 1, 45)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}