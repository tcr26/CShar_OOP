namespace StarCraft.Structures.Zerg.Basic
{
    public class Extractor : BaseObject, IZergBaseObject
    {
        public Extractor()
            : base("Extractor", 400, 1, 30)
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}