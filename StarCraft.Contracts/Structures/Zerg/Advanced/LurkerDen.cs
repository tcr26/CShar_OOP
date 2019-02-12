using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Advanced
{
    public class LurkerDen : BaseObject, IZergHealthRegeneration
    {
        public LurkerDen()
            : base("Lurker Den", 550, 1, 70, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}