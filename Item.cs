using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicItemSystem
{
    public enum SlotEnum
    {
        Head, Chest, Hands, Legs, Feet, Finger, Weapon, Usable
    }

    public class Item
    {
        private SlotEnum Slot { get; set; }
        private int Weight { get; set; }
        private int Gold_Value { get; set; }

        public Item(SlotEnum Slot, int Weight, int Gold_Value)
        {
            this.Slot = Slot;
            this.Weight = Weight;
            this.Gold_Value = Gold_Value;
        }
    }
}
