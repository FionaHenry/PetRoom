using System;
using System.Collections.Generic;

namespace PetRoom
{
    class Store
    {
        List<Item> toys = new List<Item>();
        List<Item> food = new List<Item>();
        List<Item> medicine = new List<Item>();

        public void DisplayToyStore()
        {
            foreach (Item toy in toys)
            {
                Console.WriteLine(toy.itemName);
                Console.WriteLine($"{toy.itemCost} coins");
                Console.WriteLine($"Can be used {toy.itemUses} times");
            }
        }
        public void DisplayFoodStore()
        {
            foreach (Item foodItem in food)
            {
                Console.WriteLine(foodItem.itemName);
                Console.WriteLine($"{foodItem.itemCost} coins");
                Console.WriteLine($"Can be used {foodItem.itemUses} times");
            }
        }
        public void DisplayMedicineStore()
        {
            foreach (Item med in medicine)
            {
                Console.WriteLine(med.itemName);
                Console.WriteLine($"{med.itemCost} coins");
                Console.WriteLine($" Can be used {med.itemUses} times");
            }
        }
    }
}