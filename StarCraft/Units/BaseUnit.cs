using System;
using System.Threading;

namespace StarCraft.Units
{
    public abstract class BaseUnit : StarCraftBaseObject
    {
        public BaseUnit(string objectName, int hp, int armorPoints, int construction, string rank, int movementSpeed)
            : base(objectName, hp, armorPoints, construction)
        {
            Rank = rank;
            MovementSpeed = movementSpeed;
        }

        public double MovementSpeed { get; set; }
        public string Rank { get; set; }
        public int AttackUpgradeLevel { get; set; }
        public int ArmorUpgradeLevel { get; set; }
        public int Training { get; set; }
        public string UnitName { get; set; }

        public virtual void TrainingUnit(BaseUnit unitToTrain)
        {
            Console.WriteLine("Training {0}", unitToTrain.UnitName);
            Thread.Sleep(1000 * unitToTrain.Training);
        }


    }
}
