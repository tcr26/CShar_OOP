using System;
using StarCraft.Structures.Terran.Basic;
using StarCraft;
using StarCraft.Units.Terran;
using StarCraft.Structures.Protoss.Basic;
using StarCraft.Units.Protoss;

namespace StarCraft.Units
{
    class Demo
    {
        static void Main()
        {

            Nexus baza = new Nexus();
            Zealot zelka = new Zealot();
            Console.WriteLine(baza.propertyCheck(zelka, "Shield"));
            Console.WriteLine(zelka.HitPoints);

            Marine marin = new Marine();
            Console.WriteLine(marin.HitPoints);
            Console.WriteLine(baza.propertyCheck(marin, "Shield"));

            //CommandCenter comand = new CommandCenter();
            //Console.WriteLine(comand.HitPoints);


            //SCV bob = new SCV();
            //Marine kurty = new Marine();
            //Marine lalio = new Marine();
            //Medic ani = new Medic();
            //Medic reni = new Medic();
            //Banshee petka = new Banshee();

            //if (petka is IFlyableUnit)
            //{
            //    petka.Fly();
            //}

            //Console.WriteLine(DateTime.Now);
            //lalio.TrainingUnit(lalio);
            //Console.WriteLine(DateTime.Now);

            //while (kurty.HitPoints > 0 || bob.HitPoints > 0)
            //{

            //    kurty.Attack(bob);
            //    Console.WriteLine("Health after the attack {0}", bob.HitPoints);
            //    Console.WriteLine("Mana after the heal: {0}", ani.ManaPoints);
            //    bob.Attack(kurty);
            //    Console.WriteLine("Health after the attack {0}", kurty.HitPoints);
            //    Console.WriteLine("Mana after the heal: {0}", reni.ManaPoints);

            //    if (kurty.HitPoints <= 0 || bob.HitPoints <= 0)
            //    {
            //        Console.WriteLine("OWNED");
            //        break;
            //    }

            //    if ((kurty.HitPoints < 45) || (bob.HitPoints < 45))
            //    {
            //        ani.Heal(kurty);
            //        Console.WriteLine("{0} Health after the heal {1}", "kurty", kurty.HitPoints);
            //        reni.Heal(bob);
            //        Console.WriteLine("{0} Health after the heal {1}", "bob", bob.HitPoints);
            //    }
            //}
        }
    }
}
