using System;
using System.Threading;

namespace StarCraft.Units
{
    class SCV
    {
        public SCV()
        {
        }

        public void Repair()
        {
            Console.WriteLine("Im raparing");
        }

        private void SearchForMinerals()
        {
            Console.WriteLine("Searching for minerals");
        }
        private void SearchForVespine()
        {
            Console.WriteLine("Searching for gas");
        }
    }
}
