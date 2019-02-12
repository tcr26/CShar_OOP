using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Advanced
{
    public class InfestationPit : BaseObject, IZergHealthRegeneration
    {
        public InfestationPit()
            : base("Infestation Pit", 550, 1, 80, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}