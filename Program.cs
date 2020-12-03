using System.Collections.Generic;
using System;

namespace PetRoom
{
    class Program
    {
        static List<Pet> pets = new List<Pet>();
        static void Main(string[] args)
        {
            Display display = new Display();

            display.DisplayPets(pets);

        }
        public static void Initialise()
        {
            Pet cat = new Cat("Fred");
            pets.Add(cat);
        }
    }
}
