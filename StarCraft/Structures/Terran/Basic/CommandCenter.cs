using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft.Structures.Terran.Basic
{
    public class CommandCenter : BaseStructure
    {
        public CommandCenter()
            : base("Command Center", 1500, 2, 120)
        {
            //SCVSlot = 5;
        }

        //public int SCVSlot { get; set; }
    }
}
