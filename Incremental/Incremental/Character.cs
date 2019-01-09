using System;
using System.Collections.Generic;
using System.Numerics;

namespace Incremental
{
    public class Character
    {
        public String name;
        public bool isFemale;
        //stats
        public Stat[] characterStats;
        public String[] statXPForWrite;
        public List<Gear> gear;

        public Character()
        {
            int len = StatsEnum.GetValues(typeof(StatsEnum)).Length;
            characterStats = new Stat[len];
            foreach (StatsEnum stat in StatsEnum.GetValues(typeof(StatsEnum)))
            {
                characterStats[(int)stat] = new Stat(stat);
            }
        }

        public Character(String _name, Stat[] _characterStats, bool _isFemale)
        {
            name = _name;
            characterStats = _characterStats;
            isFemale = _isFemale;
        }

        public String CharacterToString()
        {
            String r = "name: " + name + "\n" +
                "Gender: " + (isFemale ? "Female" : "Male") + "\n";
            foreach (Stat stat in characterStats)
            {
                r += stat.StatToString() + "\n";
            }
            return r;
        }

        public int GetStatLevel(StatsEnum statsEnum)
        {
            Stat stat = GetStat(statsEnum);
            int r = stat.GetLevel();
            for(int i = 0; i < gear.Count; i++)
            {
                Gear gearCurrent = gear[i];
                var statsCurrent = gearCurrent.GetStatsToAffect();
                for(int k = 0; k < statsCurrent.Length; k++)
                {
                    if(statsCurrent[k] == statsEnum)
                    {
                        r += gearCurrent.GetStatsAmount()[k];
                    }
                }
            }
            return r;
        }

        public Gear GetGearInSlot(GearSlots slot)
        {
            for(int i = 0; i < gear.Count; i++)
            {
                Gear gearCurrent = gear[i];
                if(gearCurrent.GetSlotType() == slot)
                {
                    return gearCurrent;
                }
            }
            return null;
        }

        public void SetGearInSlot(GearSlots slot, Gear _gear)
        {
            for(int i = 0; i < gear.Count; i++)
            {
                if(gear[i].GetSlotType() == slot)
                {
                    gear[i] = _gear;
                    return;
                }
            }
            gear.Add(_gear);
        }

        public Stat GetStat(StatsEnum stat)
        {
            return characterStats[(int) stat];
        }

        public void PrepareToWrite()
        {
            statXPForWrite = new String[characterStats.Length];
            for (int i = 0; i < characterStats.Length; i++)
            {
                statXPForWrite[i] = characterStats[i].GetXP().ToString();
            }
        }

        public void PostReadFromFile()
        {
            for (int i = 0; i < statXPForWrite.Length; i++)
            {
                characterStats[i].AddToStatXP(BigInteger.Parse(statXPForWrite[i]));
            }
        }
    }

    public class Stat
    {
        public static int numStats = StatsEnum.GetValues(typeof(StatsEnum)).Length;
        public static String[] names = { "Attack", "Charisma", "Toughness", "Intelligence", "Vengeance", "Ingenuity", "Dexterity", "Loyalty", "Experience" };
        public String name;
        private BigInteger xp;

        public Stat()
        {
            name = "undefined stat";
            xp = 0;
        }

        public Stat(StatsEnum stat)
        {
            name = names[(int)stat];
            xp = 0;
        }

        public String StatToString()
        {
            return name + " is: " + GetLevel();
        }

        public int GetLevel()
        {
            return Math.Max((int) (BigInteger.Log10(xp + 1) + .00001), 1);
        }

        public BigInteger GetXP()
        {
            return xp;
        }

        public void AddToStatXP(BigInteger amount)
        {
            xp += amount;
        }
    }

    public enum StatsEnum
    {
        ATTACK, CHARISMA, TOUGHNESS, INTELLIGENCE, VENGEANCE, INGENUITY, DEXTERITY, LOYALTY, EXPERIENCE
    }
}