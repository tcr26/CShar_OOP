using StarCraft.API.Controllers;
using StarCraft.Contracts.Structures.Protoss.Basic;
using StarCraft.Units.Protoss.WarpGate;
using StarCraft.Units.Terran.Barrack;
using StarCraft.Units.Zerg.SpawningPool;
using System.Collections.Generic;

namespace StarCraft
{
    public class Demo
    {
        private static void Main()
        {
            var unitController = new UnitController();

            var unit = new Marine
            {
                AttackPower = 5,
                AttackRange = 6,
                AttackRate = 1.7F,
                MovementSpeed = 1,
                Rank = "Doker",
                ObjectName = "Marin",
                HitPoints = 65,
                ArmorPoints = 0,
                ConstructionTime = 10,
                Attributes = new List<string> { "Light", "Biological" }
            };

            //{
            //	"Id" : "4",
            //	"ObjectName" : "Zergling",
            //	"HitPoints" : "25",
            //	"ArmorPoints" : "0",
            //	"ConstructionTime" : "20",
            //	"Attributes" : "Light, Biological",
            //	"Rank" : "Predator",
            //	"MovementSpeed" : "2",
            //	"AttackPower" : "5",
            //	"AttackRange" : "1",
            //	"AttackRate" : "1"
            //}

            unitController.Get(1);

            //unitController.Post(unit);

            //unitController.Put(1, unit);

            unitController.Delete(2);
        }
    }
}