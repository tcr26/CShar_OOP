using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Protoss.Basic
{
    public class Nexus : ProtossShield, IManaPoints
    {
        public Nexus()
            : base("Nexus", 200, 2, 75, 200, 2, "Armored", "Structure")

        {
            ManaPoints = 200;
        }

        public int ManaPoints { get; set; }
    }
}