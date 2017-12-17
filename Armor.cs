using System;
using BasicItemSystem;

public enum ArmorType
{
    Cloth, Leather, Plate, Accessory
}

public class Armor : Equipment
{
    ArmorType type { get; set; }
    int str_mod { get; set; }
    int agi_mod { get; set; }
    int dex_mod { get; set; }
    int armor { get; set; }


    public Armor(SlotEnum Slot, int Weight, int Gold_Value,
        int str_mod, int agi_mod, int dex_mod, int armor, ArmorType type)
        : base(Slot, Weight, Gold_Value)
    {
        this.str_mod = str_mod;
        this.agi_mod = agi_mod;
        this.dex_mod = dex_mod;
        this.armor = armor;
        this.type = type;
    }
}
