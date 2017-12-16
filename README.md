# README

## Goals
Design and implement a simple item system that generates and removes items (weapons, armor, consumables, etc.) from a gameplay instance. This system will be extended into a full inventory system that can be associated with the player character, "stash," and environment.

## TODO
* Find way to require that an item goes in a given slot. Possibly enumerated types inside of terminal class definition.
* GUI to select item to create & delete items - while keeping track of what is in existence in the "game world."
* Extend above idea into the notion of non-existence, world existence, player inventory, and stash inventory (Diablo-esque).

### OOP

* item
    * equipment
        * weapon
            * melee  
                * 2h sword  
                * 1h sword  
                * katana  
                * spear  
                * club  
                * staff  
            * ranged  
                * bow  
                * crossbow  
                * sling  
                * wand  
        * armor  
            * cloth  
            * leather  
            * plate  
            * accessories  
            * ring  
    * consumable  
        * potion  
        * bombs  