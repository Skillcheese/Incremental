using System;
using System.Collections.Generic;
using System.Numerics;

namespace Incremental
{
    public class Character
    {
        public string name;
        public bool isFemale;
        //stats
        public Stat[] characterStats;
        public string[] statXPForWrite;
        public List<Gear> gear = new List<Gear>();
        public BigInteger health;
        public string healthForWrite;
        public SkillsObject skills;
        
        public Character()
        {
        }

        public Character(string _name, Stat[] _characterStats, bool _isFemale)
        {
            name = _name;
            characterStats = _characterStats;
            isFemale = _isFemale;
            health = GetHealthMax();
            skills = new SkillsObject(true);
        }

        public void Die()
        {
            health = GetHealthMax();
            GetStat(StatsEnum.VENGEANCE).AddToStatXP(BigInteger.Pow(Number.logBase, GetStatLevel(StatsEnum.VENGEANCE)));
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
                var statsCurrent = gearCurrent.statsToAffect;
                for(int k = 0; k < statsCurrent.Length; k++)
                {
                    if(statsCurrent[k] == statsEnum)
                    {
                        r += gearCurrent.statsAmount[k];
                    }
                }
            }
            return r;
        }

        public BigInteger GetHealthMax()
        {
            return (GetStatLevel(StatsEnum.TOUGHNESS) * GetStatLevel(StatsEnum.LOYALTY) + 9) * 10;
        }

        public bool TakeDamage(BigInteger damage)
        {
            BigInteger armor = GetArmor();
            damage -= armor;
            if(damage > 0)
            {
                health -= damage;
            }
            return health <= 0;
        }

        public BigInteger GetArmor()
        {
            return GetStatLevel(StatsEnum.TOUGHNESS) / 3;
        }

        public AttackType GetAttackType()
        {
            Gear weaponRight = GetGearInSlot(GearSlots.RIGHTHAND);
            Gear weaponLeft = GetGearInSlot(GearSlots.LEFTHAND);
            double damageMelee = 0, damageRanged = 0, damageMagic = 0;
            if (weaponRight != null)
            {
                weaponRight.GetDamageTypes(ref damageMelee, ref damageRanged, ref damageMagic, true);
            }
            if (weaponLeft != null)
            {
                weaponLeft.GetDamageTypes(ref damageMelee, ref damageRanged, ref damageMagic, false);
            }
            double max = Math.Max(Math.Max(damageMelee, damageRanged), damageMagic);
            if (max == 0) return AttackType.MELEE;
            AttackType attackType = AttackType.NONE;
            if (max == damageMelee) attackType = AttackType.MELEE;
            if (max == damageRanged) attackType = AttackType.RANGED;
            if (max == damageMagic) attackType = AttackType.MAGIC;
            return attackType;
        }

        public BigInteger GetDamage()
        {
            Gear weaponRight = GetGearInSlot(GearSlots.RIGHTHAND);
            Gear weaponLeft = GetGearInSlot(GearSlots.LEFTHAND);
            double damageMelee = 0, damageRanged = 0, damageMagic = 0;
            if(weaponRight != null)
            {
                weaponRight.GetDamageTypes(ref damageMelee, ref damageRanged, ref damageMagic, true);
            }
            if(weaponLeft != null)
            {
                weaponLeft.GetDamageTypes(ref damageMelee, ref damageRanged, ref damageMagic, false);
            }
            double max = Math.Max(Math.Max(damageMelee, damageRanged), damageMagic);
            AttackType attackType = AttackType.NONE;
            if (max == damageMelee) attackType = AttackType.MELEE;
            if (max == damageRanged) attackType = AttackType.RANGED;
            if (max == damageMagic) attackType = AttackType.MAGIC;
            switch (attackType)
            {
                case AttackType.NONE:
                    return 0;
                case AttackType.MELEE:
                    return new BigInteger(damageMelee + GetStatLevel(StatsEnum.ATTACK)) * GetStatLevel(StatsEnum.VENGEANCE);
                case AttackType.RANGED:
                    return new BigInteger(damageRanged + GetStatLevel(StatsEnum.DEXTERITY)) * GetStatLevel(StatsEnum.VENGEANCE);
                case AttackType.MAGIC:
                    return new BigInteger(damageMagic + GetStatLevel(StatsEnum.INTELLIGENCE)) * GetStatLevel(StatsEnum.VENGEANCE);
            }
            return 0;
        }

        public Gear GetGearInSlot(GearSlots slot)
        {
            for(int i = 0; i < gear.Count; i++)
            {
                Gear gearCurrent = gear[i];
                if(gearCurrent.slotType == slot)
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
                if(gear[i].slotType == slot)
                {
                    gear[i] = _gear;
                    return;
                }
            }
            gear.Add(_gear);
        }

        public int GetPowerLevel()
        {
            int r = 1;
            foreach (StatsEnum stat in Enum.GetValues(typeof(StatsEnum)))
            {
                if(characterStats[(int)stat].IsCombatStat())
                {
                    r += (int) Math.Pow(characterStats[(int)stat].GetLevel(), 1.1);
                }
            }
            return r;
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
            healthForWrite = health.ToString();
        }

        public void PostReadFromFile()
        {
            for (int i = 0; i < statXPForWrite.Length; i++)
            {
                characterStats[i].AddToStatXP(BigInteger.Parse(statXPForWrite[i]));
            }
            health = BigInteger.Parse(healthForWrite);
        }
    }

    public class Stat
    {
        public static int numStats = StatsEnum.GetValues(typeof(StatsEnum)).Length;
        public static string[] names = { "Attack", "Charisma", "Toughness", "Intelligence", "Vengeance", "Ingenuity", "Dexterity", "Loyalty", "Experience" };
        public string name;
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

        public string StatToString()
        {
            return name + ": " + GetLevel();
        }

        public string StatToStringLong()
        {
            return StatToString() + " XP: " + xp.ToString();
        }

        public int GetLevel()
        {
            return Math.Max((int) (BigInteger.Log(xp) / Math.Log((double) Number.logBase) + .00001), 1);
        }

        public BigInteger GetXP()
        {
            return xp;
        }

        public void AddToStatXP(BigInteger amount)
        {
            xp += amount;
            xp = BigInteger.Max(xp, 0);
        }

        public bool IsCombatStat()
        {
            switch (name)
            {
                case "Attack":
                case "Toughness":
                case "Intelligence":
                case "Vengeance":
                case "Dexterity":
                case "Loyalty":
                case "Experience":
                    return true;
            }
            return false;
        }
    }

    public enum AttackType
    {
        NONE, MELEE, RANGED, MAGIC
    }

    public enum StatsEnum
    {
        ATTACK, CHARISMA, TOUGHNESS, INTELLIGENCE, VENGEANCE, INGENUITY, DEXTERITY, LOYALTY, EXPERIENCE
    }
}