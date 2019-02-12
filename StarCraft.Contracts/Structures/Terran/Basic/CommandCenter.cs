using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Terran.Basic
{
    public class CommandCenter : BaseObject, IManaPoints
    {
        public CommandCenter()
            : base("Command Center", 400, 2, 140, "Mechanical", "Structure")

        {
            ManaPoints = 200;
        }

        public int ManaPoints { get; set; }
    }
}