using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage_2
{
    class Skill
    {
        public Skill(int reuse, string skillName, int chanceToLand, int skillLevel)
        {
            ReUseTime = reuse;
            SkillName = skillName;
            ChanceToLand = chanceToLand;
            SkillLevel = skillLevel;
        }

        public int ReUseTime { get; set; }
        public string SkillName { get; set; }
        public int ChanceToLand { get; set; }
        public int SkillLevel { get; set; }
    }
}
