using StarCraft.Contracts.Interfaces;

namespace StarCraft.Units.Terran.Barrack
{
    public class Medic : BaseObject, IManaPoints
    {
        public Medic()
            : base("Medic", 55, 0, 35, "Light", "Biological")
        {
            ManaPoints = 200;
        }

        public int ManaPoints { get; set; }
    }
}