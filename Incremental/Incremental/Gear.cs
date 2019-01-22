using System;

namespace Incremental
{
    public class Gear
    {
        public string name;
        public int[] statsAmount;
        public StatsEnum[] statsToAffect;
        public GearSlots slotType;
        public double damage;
        public AttackType attackType;

        public Gear()
        {
            name = "No gear here";
            statsAmount = new int[0];
            statsToAffect = new StatsEnum[0];
            slotType = GearSlots.NOSLOTSPECIFIED;
            damage = 0;
        }

        public Gear(String _name, int[] _statsAmount, StatsEnum[] _statsToAffect, GearSlots _slotType, double _damage = -1, AttackType _attackType = AttackType.NONE)
        {
            name = _name;
            statsAmount = _statsAmount;
            statsToAffect = _statsToAffect;
            slotType = _slotType;
            damage = _damage;
            attackType = _attackType;
        }

        public bool GetDamageTypes(ref double melee, ref double ranged, ref double magic, bool righthand)
        {
            switch (attackType)
            {
                case AttackType.NONE:
                    return false;
                case AttackType.MELEE:
                    melee += damage * (righthand ? 1 : .7);
                    break;
                case AttackType.RANGED:
                    ranged += damage * (righthand ? 1 : .7);
                    break;
                case AttackType.MAGIC:
                    magic += damage * (righthand ? 1 : .7);
                    break;
            }
            return true;
        }

        public void SetStatsToAffect(StatsEnum[] _statsToAffect)
        {
            statsToAffect = _statsToAffect;
        }

        public void SetStatsAmount(int[] _statsAmount)
        {
            statsAmount = _statsAmount;
        }
    }

    public enum GearSlots
    {
        NOSLOTSPECIFIED, FEET, LEGS, CHEST, HEAD, HANDS, SHOULDERS, WAIST, RING1, RING2, NECKLACE, LEFTHAND, RIGHTHAND, BACK
    }
}
