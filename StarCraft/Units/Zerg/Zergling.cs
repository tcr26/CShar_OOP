using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft.Units.Zerg
{
    class Zergling : BaseUnit
    {
        public Zergling(string objectName, int hp, int armorPoints, int construction, string rank, int movementSpeed)
            : base(objectName, hp, armorPoints, construction, rank, movementSpeed)
        {
        }
    }
}
