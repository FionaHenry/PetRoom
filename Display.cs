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

        public void DisplayRoom()
        {

        }
    }
}