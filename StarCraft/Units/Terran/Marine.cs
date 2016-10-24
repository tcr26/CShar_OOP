using System;
using System.Threading;

namespace StarCraft.Units
{
    public class Marine : BaseUnitAdvanced
    {
        public Marine()
            : base(5, 1, 1, 0, "Marine", 45, 0, 20, 0, "Private", 1)
        {
        }
        public void UseStimPack()
        {
            if (HitPoints > 10)
            {
                Console.WriteLine("Hell YEAH!Using Stim Pack");
                HitPoints -= 10;
            }
            else
            {
                Console.WriteLine("Not Enough HitPoints");
            }
        }

        public void EquipCombatShield()
        {
            Console.WriteLine("Combat Shield Equiped");
            HitPoints += 10;
        }

        //public override void Attack(BaseUnit unitToAttack)
        //{
        //    base.Attack(unitToAttack);
        //    Thread.Sleep((int)(500 / AttackSpeed));
        //}


        //public override void TrainingUnit(BaseUnit UnitToTrain)
        //{
        //    Console.WriteLine("Start");
        //    base.TrainingUnit(UnitToTrain);
        //    Console.WriteLine("DONE");
        //}
    }
}
