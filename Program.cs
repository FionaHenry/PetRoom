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
            Initialise();
            display.DisplayPets(pets);
            //display.DisplayMenu();

        }
        public static void Initialise()
        {
            Pet cat = new Cat("Fred");
            pets.Add(cat);
        }
    }
}
