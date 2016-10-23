using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage_2
{
    public abstract class CharacterBase
    {
        protected CharacterBase(int st, int dx, int cn, List<Skill> skills, int charLevel)
        {
            Str = st;
            Dex = dx;
            Con = cn;
            Skills = skills;
            CharLevel = charLevel;
        }

        protected int Str { get; set; }
        protected int Dex { get; set; }
        protected int Con { get; set; }
        protected int Int { get; set; }
        protected int Wit { get; set; }
        protected int Men { get; set; }

        protected string Gender { get; set; }

        protected string Race { get; set; }

        protected string CharName { get; set; }

        protected int CharLevel { get; set; }

        protected List<Skill> Skills { get; set; }
    }
}
