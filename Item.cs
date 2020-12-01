using System;

namespace PetRoom
{
    public class Item
    {
        public string itemName;
        public int itemCost;
        public int itemUses;

        public Item(string name, int cost, int uses)
        {
            this.itemName = name;
            this.itemCost = cost;
            this.itemUses = uses;
        }
    }
}