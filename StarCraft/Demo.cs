using StarCraft.Units.Protoss;
using StarCraft.Units.Terran;
using StarCraft.Units.Zerg;
using System;

namespace StarCraft.Units
{
    public class Demo
    {
        private static void Main()
        {
            Zealot zealot = new Zealot();
            Console.WriteLine(zealot.ObjectName);
            Console.WriteLine(zealot.Shield);
            Console.WriteLine(zealot.AttackPower);
            Console.WriteLine(zealot.AttackRange);
            Console.WriteLine(zealot.AttackRate);

            Marine marine = new Marine();
            Console.WriteLine(marine.ObjectName);
            Console.WriteLine(marine.HitPoints);
            Console.WriteLine(marine.AttackPower);
            Console.WriteLine(marine.AttackRange);
            Console.WriteLine(marine.AttackRate);

            Medic medic = new Medic();
            Console.WriteLine(medic.ObjectName);
            Console.WriteLine(medic.ManaPoints);

            Zergling zergling = new Zergling();
            Console.WriteLine(zergling.ObjectName);
            Console.WriteLine(zergling.HitPointsRegenerateRate);
            Console.WriteLine(zergling.AttackPower);
            Console.WriteLine(zergling.AttackRange);
            Console.WriteLine(zergling.AttackRate);
            Console.ReadKey();
        }
    }
}