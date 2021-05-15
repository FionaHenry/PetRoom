using System;
using System.Collections.Generic;

namespace PetTrySimulation
{
    class Display
    {
        public static Room room = new Room();
        
        public void DisplayPets(List<Pet> pets)
        {
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"{pet.sprite} - {pet.name}");
                Console.WriteLine($"Health: {pet.health}");
                Console.WriteLine($"Boredom: {pet.boredom}");
                Console.WriteLine($"Hunger: {pet.hunger}");
            }
            Console.WriteLine($"Room temperature: {Math.Round(room.currentTemperature, 2)}");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Open Store - 1");
            Console.WriteLine("Show Inventory - 2");
            Console.WriteLine("Show Pets - 3");
        }

        public void DisplayStore()
        {
            Console.WriteLine("1 - Toy Store");
            Console.WriteLine("2 - Food Store");
            Console.WriteLine("3 - Medicine Store");
        }
        
    }
}