using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Advanced
{
    public class UltraliskCavern : BaseObject, IZergHealthRegeneration
    {
        public UltraliskCavern()
            : base("Ultralisk Cavern", 800, 1, 90, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}