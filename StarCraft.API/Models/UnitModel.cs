using System.Collections.Generic;

namespace StarCraft.API.Models
{
    public class UnitModel
    {
        //BaseObject
        public int Id { get; set; }

        public string ObjectName { get; set; }

        public int HitPoints { get; set; }

        public int ArmorPoints { get; set; }

        public int ConstructionTime { get; set; }

        public IList<string> Attributes { get; set; }

        //protoss object
        public int Shield { get; set; }

        public int ShieldArmor { get; set; }

        //interfaces

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public int MovementSpeed { get; set; }

        public string Rank { get; set; }

        public int ManaPoints { get; set; }

        public int HitPointsRegenerateRate { get; set; }
    }
}