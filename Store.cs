using System;
using System.Collections.Generic;

namespace PetTrySimulation
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
                Console.WriteLine($"{toy.itemName}, {toy.itemCost} coins, can be used {toy.itemUses} times");
            }
        }
        
        public void DisplayFoodStore()
        {
            foreach (Item foodItem in food)
            {
                Console.WriteLine($"{foodItem.itemName}, {foodItem.itemCost} coins, can be used {foodItem.itemUses} times");
            }
        }
        public void DisplayMedicineStore()
        {
            foreach (Item med in medicine)
            {
                Console.WriteLine($"{med.itemName}, {med.itemCost} coins, can be used {med.itemUses} times");
            }
        }

        public void InitialiseStore()
        {
            food.Add(new Item("Cat Food", 5, 2));
            food.Add(new Item("Luxury Cat Food", 6, 1));
            toys.Add(new Item("Small Cat Toy", 5, 1));
            toys.Add(new Item("Luxury Cat Toy", 25, 10));
            medicine.Add(new Item("Cat Medicine", 5, 2));
        }

        public void PurchaseItem()
        {
            
        }
    }
}