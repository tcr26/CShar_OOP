using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Basic
{
    public class EvolutionChamber : BaseObject, IZergHealthRegeneration
    {
        public EvolutionChamber()
            : base("Evolution Chamber", 450, 1, 45, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}