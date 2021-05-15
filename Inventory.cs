using System;
using System.Collections.Generic;

namespace PetTrySimulation
{
    class Inventory
    {
        public static List<Item> inventory = new List<Item>();

        public int coins = 10;

        public void DisplayInventory()
        {
            Console.WriteLine("Your Inventory");
            Console.WriteLine($"You have {coins} coins available to spend");
            foreach (Item item in inventory)
            {
                Console.WriteLine(item.itemName);
                Console.WriteLine($"Uses remaining: {item.itemUses}");
            }
        }
    }
}