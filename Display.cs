using System;
using System.Collections.Generic;

namespace PetRoom
{
    public class Display
    {
        List<Pet> pets = new List<Pet>();
        Pet cat = new Cat("Fred");

        public void DisplayPetRoom()
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
    }
}