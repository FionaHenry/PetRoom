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
            Console.WriteLine("Press 4 to feed your pet");
            Console.WriteLine("Press 5 to play with your pet");
            Console.WriteLine("Press 6 to give your pet medicine");
        }

        public void Update()
        {
            coins++;
        }
    }
}