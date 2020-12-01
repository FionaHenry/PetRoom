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
                Console.WriteLine(toy.itemCost);
                Console.WriteLine(toy.itemUses);
            }
        }
        public void DisplayFoodStore()
        {
            foreach (Item foodItem in food)
            {
                Console.WriteLine(foodItem.itemName);
                Console.WriteLine(foodItem.itemCost);
                Console.WriteLine(foodItem.itemUses);
            }
        }
        public void DisplayMedicineStore()
        {
            foreach (Item med in medicine)
            {
                Console.WriteLine(med.itemName);
                Console.WriteLine(med.itemName);
                Console.WriteLine(med.itemName);
            }
        }
    }
}