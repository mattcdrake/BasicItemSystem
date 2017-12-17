using System;
using BasicItemSystem;

public class Weapon : Equipment
{
    int str_mod { get; set; }
    int agi_mod { get; set; }
    int dex_mod { get; set; }
    int dmg { get; set; }


    public Weapon(SlotEnum Slot, int Weight, int Gold_Value,
        int str_mod, int agi_mod, int dex_mod, int dmg)
        : base(Slot, Weight, Gold_Value) 
	{
        this.str_mod = str_mod;
        this.agi_mod = agi_mod;
        this.dex_mod = dex_mod;
        this.dmg = dmg;
	}
}
