using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Basic
{
    public class RoachWarren : BaseObject, IZergHealthRegeneration
    {
        public RoachWarren()
            : base("Roach Warren", 650, 1, 45, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}