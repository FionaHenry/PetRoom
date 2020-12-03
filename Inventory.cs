using System;
using System.Collections.Generic;

namespace PetRoom
{
    class Inventory
    {
        List<Item> inventory = new List<Item>();

        public int coins;

        public void DisplayInventory()
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine(item.itemName);
                Console.WriteLine($"Uses remaining: {item.itemUses}");
            }
        }
    }
}