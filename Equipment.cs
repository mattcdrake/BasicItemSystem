using System;
using BasicItemSystem;

public class Equipment : Item
{
    private int Durability { get; set; }
    private bool IsBroken { get; set; }

    public Equipment(SlotEnum Slot, int Weight, int Gold_Value) 
        : base(Slot, Weight, Gold_Value)
	{
        Durability = 100;
        IsBroken = false;
	}

    public void Repair()
    {
        IsBroken = false;
        this.Durability = 100;
    }

    public void Degrade(int i)
    {
        if (Durability - i <= 0)
        {
            IsBroken = true;
            Durability = 0;
        }
        else
        {
            Durability -= i;
        }
    }
}
