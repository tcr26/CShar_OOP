
using System;
namespace StarCraft.Units.Terran
{
    public class Banshee
    {
        public Banshee()
        {
            CanAttackGroundUnit = false;
        }

        public bool CanAttackGroundUnit { get; set; }

        public void Fly()
        {
            Console.WriteLine("Banshee is Flying");
        }
    }
}
