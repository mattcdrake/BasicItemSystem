using System;
using BasicItemSystem;

public class Consumable : Item
{
    private int UseCount { get; set; }

    public Consumable(SlotEnum Slot, int Weight, int Gold_Value, int UseCount) 
        : base(Slot, Weight, Gold_Value)
    {
        this.UseCount = UseCount;
    }

    // Returns true if the item is completely expended after the current use
    public bool Use()
    {
        if (UseCount - 1 <= 0)
        {
            return true;
        }
        UseCount--;
        return false;
    }
}
