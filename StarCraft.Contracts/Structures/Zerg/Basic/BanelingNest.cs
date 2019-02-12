using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Basic
{
    public class BanelingNest : BaseObject, IZergHealthRegeneration
    {
        public BanelingNest()
            : base("Baneling Nest", 750, 1, 55, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}