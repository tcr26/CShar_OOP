using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Basic
{
    public class Extractor : BaseObject, IZergHealthRegeneration
    {
        public Extractor()
            : base("Extractor", 400, 1, 30, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}