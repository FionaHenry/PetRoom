using System;

namespace PetRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //prolly make an app class later so all this class does is run it... cos SOLID
            Pet cat = new Cat("Fred");

            cat.Display();

            
        }
    }
}
