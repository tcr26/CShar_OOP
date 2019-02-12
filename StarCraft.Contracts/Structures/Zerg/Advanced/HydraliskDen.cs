using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Advanced
{
    public class HydraliskDen : BaseObject, IZergHealthRegeneration
    {
        public HydraliskDen()
            : base("Hydralisk Den", 450, 1, 55, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}