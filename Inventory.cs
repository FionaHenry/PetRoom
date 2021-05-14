using System;
using System.Collections.Generic;

namespace PetTrySimulation
{
    class Inventory
    {
        public List<Item> inventory = new List<Item>();

        public int coins = 10;

        public void DisplayInventory()
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine($"You have {coins} coins available to spend");
                Console.WriteLine(item.itemName);
                Console.WriteLine($"Uses remaining: {item.itemUses}");
            }
        }
    }
}