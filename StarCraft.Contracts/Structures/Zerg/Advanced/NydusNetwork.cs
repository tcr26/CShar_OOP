using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Advanced
{
    public class NydusNetwork : BaseObject, IZergHealthRegeneration
    {
        public NydusNetwork()
            : base("Nydus Network", 400, 1, 60, "Armored", "Structure")
        {
            HitPointsRegenerateRate = 3;
        }

        public int HitPointsRegenerateRate { get; set; }
    }
}