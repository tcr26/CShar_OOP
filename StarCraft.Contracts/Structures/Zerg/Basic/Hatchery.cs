using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Basic
{
    public class Hatchery : BaseObject, IZergHealthRegeneration
    {
        public Hatchery()
            : base("Hatchery", 1500, 1, 80, "Armored", "Structure", "Biological")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}