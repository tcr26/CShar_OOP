﻿using StarCraft.Contracts.Interfaces;

namespace StarCraft.Contracts.Structures.Zerg.Basic
{
    public class SporeCrawler : BaseObject, IZergHealthRegeneration, IAttackObject
    {
        public SporeCrawler()
            : base("Spore Crawler", 450, 1, 35, "Armored", "Structure")
        {
            AttackPower = 7;
            AttackRange = 1;
            AttackRate = 1;
            HitPointsRegenerateRate = 2;
        }

        public int AttackPower { get; set; }

        public int AttackRange { get; set; }

        public float AttackRate { get; set; }

        public int HitPointsRegenerateRate { get; set; }
    }
}