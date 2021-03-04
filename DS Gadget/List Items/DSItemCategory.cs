﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DS_Gadget
{
    class DSItemCategory
    {
        public string Name;
        public int ID;
        public List<DSItem> Items;

        private DSItemCategory(string name, int id, string itemList, bool showIDs)
        {
            Name = name;
            ID = id;
            Items = new List<DSItem>();
            foreach (string line in Regex.Split(itemList, "[\r\n]+"))
                Items.Add(new DSItem(line, showIDs));
            Items.Sort();
        }

        public override string ToString()
        {
            return Name;
        }

        public static List<DSItemCategory> All = new List<DSItemCategory>()
        {
            new DSItemCategory("Armor", 0x10000000, Properties.Resources.Armor, false),
            new DSItemCategory("Consumables", 0x40000000, Properties.Resources.Consumables, false),
            new DSItemCategory("Key Items", 0x40000000, Properties.Resources.KeyItems, false),
            new DSItemCategory("Melee Weapons", 0x00000000, Properties.Resources.MeleeWeapons, false),
            new DSItemCategory("Ranged Weapons", 0x00000000, Properties.Resources.RangedWeapons, false),
            new DSItemCategory("Rings", 0x20000000, Properties.Resources.Rings, false),
            new DSItemCategory("Shields", 0x00000000, Properties.Resources.Shields, false),
            new DSItemCategory("Spells", 0x40000000, Properties.Resources.Spells, false),
            new DSItemCategory("Spell Tools", 0x00000000, Properties.Resources.SpellTools, false),
            new DSItemCategory("Upgrade Materials", 0x40000000, Properties.Resources.UpgradeMaterials, false),
            new DSItemCategory("Usable Items", 0x40000000, Properties.Resources.UsableItems, false),
        };
    }
}
