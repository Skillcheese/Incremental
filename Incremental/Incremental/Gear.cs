using System;

namespace Incremental
{
    public class Gear
    {
        private string name;
        private int[] statsAmount;
        private StatsEnum[] statsToAffect;
        private GearSlots slotType;

        public Gear()
        {
            name = "No gear here";
            statsAmount = new int[0];
            statsToAffect = new StatsEnum[0];
            slotType = GearSlots.NOSLOTSPECIFIED;
        }

        public Gear(String _name, int[] _statsAmount, StatsEnum[] _statsToAffect, GearSlots _slotType)
        {
            name = _name;
            statsAmount = _statsAmount;
            statsToAffect = _statsToAffect;
            slotType = _slotType;
        }

        public void SetSlotType(GearSlots _slotType)
        {
            slotType = _slotType;
        }

        public GearSlots GetSlotType()
        {
            return slotType;
        }

        public void SetStatsToAffect(StatsEnum[] _statsToAffect)
        {
            statsToAffect = _statsToAffect;
        }

        public StatsEnum[] GetStatsToAffect()
        {
            return statsToAffect;
        }

        public void SetStatsAmount(int[] _statsAmount)
        {
            statsAmount = _statsAmount;
        }
        
        public int[] GetStatsAmount()
        {
            return statsAmount;
        }

        public void SetName(String _name)
        {
            name = _name;
        }

        public String GetName()
        {
            return name;
        }
    }

    public enum GearSlots
    {
        NOSLOTSPECIFIED, FEET, LEGS, CHEST, HEAD, HANDS, SHOULDERS, WAIST, RING1, RING2, NECKLACE
    }
}
