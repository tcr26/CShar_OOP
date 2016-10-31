using System;
using StarCraft.Units.Protoss;
using StarCraft.Structures.Protoss.Basic;
using System.Collections.Generic;
using System.Linq;
namespace StarCraft.Units
{
    class Demo
    {
        static void Main()
        {
            Zealot zelka = new Zealot();
            //Console.WriteLine(zelka.Shield);

            Marine marin = new Marine();
            //Console.WriteLine(marin.ManaPoints);

            if (zelka is ProtossBaseObject)
            {
                marin.AttackShield(zelka, zelka);
            }
            if (!(marin is ProtossBaseObject))
            {
                while (marin.HitPoints >= 0)
                {
                    zelka.AttackHitPoints(marin);
                }
            }

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
