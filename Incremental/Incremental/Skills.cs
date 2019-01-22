using System;
using System.Collections.Generic;

namespace Incremental
{
    public class SkillsObject
    {
        public List<Skill> skills;

        public SkillsObject()
        {
            skills = new List<Skill>();
        }

        public SkillsObject(bool shouldInit)
        {
            skills = new List<Skill>();
            foreach (SkillType type in Enum.GetValues(typeof(SkillType)))
            {
                skills.Add(new Skill(type));
            }
            GetSkill(SkillType.NOTALLOCATED).value = 5000;
        }

        public Skill GetSkill(SkillType type)
        {
            return skills.Find(x => x.type == type);
        }

        public void Update()
        {
            for(int i = 0; i < skills.Count; i++)
            {
                Skill skill = skills[i];
                int value = skill.value;
                if (value == 0) continue; 
                switch (skill.type)
                {
                    case SkillType.IncreasedTickRate:
                        Game.msPerUpdate = (int) (Game.tickRateBase *  Math.Pow(.95, value));
                        break;
                    case SkillType.Ability_AutoClicker:
                        for(int k = 0; k < value; k++)
                        {
                            Form_MainMenu.PlayerAttackButton();
                        }
                        break;
                }
            }
        }
    }

    public class Skill
    {
        public SkillType type;
        public int value;

        public Skill()
        {
            type = SkillType.NOTALLOCATED;
            value = 0;
        }

        public Skill(SkillType _type)
        {
            type = _type;
            value = 0;
        }

        public bool CanUpgrade()
        {
            if (Game.player.skills.GetSkill(SkillType.NOTALLOCATED).value <= 0) return false;
            List<SkillRequirement> reqs = Skills.GetSkillRequirementTable(type);
            if (reqs.Count == 0) return false;
            foreach(SkillRequirement req in reqs)
            {
                if(!req.IsRequirementMet(value + 1))
                {
                    return false;
                }
            }
            return true;
        }

        public void Upgrade()
        {
            Game.player.skills.GetSkill(SkillType.NOTALLOCATED).value--;
            value++;
        }
    }

    public abstract class Skills
    {
        public static int size = 101;

        public static List<SkillRequirement> GetSkillRequirementTable(SkillType type)
        {
            List<SkillRequirement> r = new List<SkillRequirement>();
            switch (type)
            {
                case SkillType.NOTALLOCATED:
                    break;
                case SkillType.IncreasedTickRate:
                    r.Add(new SkillRequirement(StatsEnum.ATTACK, new Equation(5)));
                    r.Add(new SkillRequirement(null, new Equation(15, 5)));
                    break;
                case SkillType.Ability_AutoClicker:
                    r.Add(new SkillRequirement(StatsEnum.ATTACK, new Equation(3, 7)));
                    r.Add(new SkillRequirement(null, new Equation(3, 2, 15)));
                    break;
            }
            return r;
        }

        public static void GetValues(SkillType type, out string name, out string description, out bool ability)
        {
            ability = false;
            name = "NO NAME";
            description = "NO DESCRIPTION";
            switch (type)
            {
                case SkillType.NOTALLOCATED:
                    name = "Skill Tree";
                    description = "This is your skill tree\nspend skill points to improve your character";
                    return;
                case SkillType.Ability_AutoClicker:
                    name = "Auto Clicker";
                    description = "click X number of times per tick";
                    ability = true;
                    break;
                case SkillType.Ability_DealDamageOverkill:
                    name = "Deal Overkill";
                    description = "Deal X damage (with overkill) single use";
                    ability = true;
                    break;
                case SkillType.IncreasedTickRate:
                    name = "Increased Tick Rate";
                    description = "Increase the tick rate by 5%";
                    break;
            }
            description += "\nLevel: " + Game.player.skills.GetSkill(type).value;
            description += "\nRequirements:";
            List<SkillRequirement> list = GetSkillRequirementTable(type);
            for (int i = 0; i < list.Count; i++)
            {
                description += "\n";
                if(list[i].isPowerlevel)
                {
                    description += "Powerlevel: ";
                }
                else
                {
                    description += Game.player.GetStat(list[i].stat).name + " ";
                }
                description += list[i].equation.GetValue(Game.player.skills.GetSkill(type).value + 1);
            }
        }
    }

    public enum SkillType
    {
        NOTALLOCATED,
        //MELEE
        IncreasedTickRate, IncreasedArmor, IncreasedMaxHealth, IncreasedDurability,
        Ability_AutoClicker, Ability_ExtraDPT, Ability_GainArmor,
        //RANGED
        Overkill, Multishot,
        Ability_DealDamageToXEnemies, Ability_DealDamageOverkill, 
        //MAGIC
        IncreasedManaRegen, EnemyArmorReductionOnHit, 
        Ability_HealDOT, Ability_Sunder, Ability_SunderChunk,
        Ability_GainExtraXP, Ability_GainExtraGold,
        //COMMON
        IncreasedDPT, IncreasedAttackDamage, IncreasedScaling, 
        //extra racial damage
        ExtraDamageOrc, ExtraDamageGoblin, ExtraDamageHuman, 
        //extra type damage
        ExtraDamageLight, ExtraDamageArmored, ExtraDamageGiant,

        HealthRegen, 
    }

    public class SkillRequirement
    {
        /// <summary>
        /// The stat required to get this skill
        /// </summary>
        public StatsEnum stat;
        /// <summary>
        /// The equation which governs how many of what stats the player needs in order to purchase this skill
        /// </summary>
        public Equation equation;
        /// <summary>
        /// Will be true if this stat requirement is for combat level
        /// </summary>
        public bool isPowerlevel;

        public SkillRequirement()
        {
        }

        public SkillRequirement(StatsEnum _stat, Equation _equation)
        {
            stat = _stat;
            equation = _equation;
        }
        /// <summary>
        /// Null in first argument means it's a powerlevel requirement
        /// </summary>
        /// <param name="p"></param>
        /// <param name="equation"></param>
        public SkillRequirement(object p, Equation equation)
        {
            isPowerlevel = true;
            this.equation = equation;
        }

        /// <summary>
        /// Checks if the requirements are met for this skill, at a specified level of the skill
        /// if we're trying to get to level 3 then you'd pass in 3, even though the skill is currently at level 2
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsRequirementMet(int value)
        {
            if(isPowerlevel)
            {
                return Game.player.GetPowerLevel() >= equation.GetValue(value);
            }
            return Game.player.GetStatLevel(stat) >= equation.GetValue(value);
        }
    }

    public class Equation
    {
        private EquationType type;
        private double a = 1;
        private double b = 1;
        private double c = 0;

        public Equation()
        {
            type = EquationType.Linear;
        }

        public Equation(double _a, double _c = 0)
        {
            a = _a;
            c = _c;
            type = EquationType.Linear;
        }

        public Equation(double _a, double _b, double _c = 0)
        {
            a = _a;
            b = _b;
            c = _c;
            type = EquationType.Exponential;
        }

        public int GetValue(int level)
        {
            double r = 0;
            switch (type)
            {
                case EquationType.Linear:
                    r = a * level;
                    break;
                case EquationType.Exponential:
                    r = a * Math.Pow(b, level);
                    break;
            }
            r += c;
            return (int) r;
        }
    }

    public enum EquationType
    {
        Linear, Exponential
    }
}
