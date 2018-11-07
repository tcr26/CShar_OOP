namespace StarCraft.Structures.Zerg.Advanced
{
    public class NydusNetwork : BaseObject, IZergBaseObject
    {
        public NydusNetwork()
            : base("Nydus Network", 400, 1, 60)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}