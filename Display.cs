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
                Console.WriteLine(pet.sprite);
                Console.WriteLine(pet.name);
                Console.WriteLine(pet.health);
                Console.WriteLine(pet.boredom);
                Console.WriteLine(pet.hunger);
            }
        }

        public void DisplayRoom()
        {
            
        }
    }
}