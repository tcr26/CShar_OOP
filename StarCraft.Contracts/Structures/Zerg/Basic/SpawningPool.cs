using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Basic
{
    public class SpawningPool : BaseObject, IZergHealthRegeneration
    {
        public SpawningPool()
            : base("Spawning Pool", 1000, 1, 55, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}