using System;
using System.Collections.Generic;

namespace PetRoom
{
    class Display
    {
        Room room = new Room();
        
        public void DisplayPets(List<Pet> pets)
        {
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"{pet.sprite} - {pet.name}");
                Console.WriteLine($"Health: {pet.health}");
                Console.WriteLine($"Boredom: {pet.boredom}");
                Console.WriteLine($"Hunger: {pet.hunger}");
            }
            Console.WriteLine($"Room temperature: {room.currentTemperature}");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Open Store - 1");
            Console.WriteLine("Show Inventory - 2");
        }
    }
}