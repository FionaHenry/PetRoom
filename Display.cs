using System;
using System.Collections.Generic;

namespace PetRoom
{
    class Display
    {
        
        
        public void DisplayPets(List<Pet> pets)
        {
            foreach (Pet pet in pets)
            {
                Console.WriteLine($"{pet.sprite} - {pet.name}");
                Console.WriteLine($"Health {pet.health}");
                Console.WriteLine($"Boredom: {pet.boredom}");
                Console.WriteLine($"Hunger: {pet.hunger}");
            }
        }

        public void DisplayMenu()
        {
            Console.SetCursorPosition(50, 1);
            Console.Write("Menu");
            Console.SetCursorPosition(50, 3);
            Console.Write("Open Store - 1");
            Console.SetCursorPosition(50, 5);
            Console.Write("Show Inventory - 2");
        }
    }
}