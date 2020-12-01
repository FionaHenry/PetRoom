using System;

namespace PetRoom
{
    class Pet
    {
        public string sprite;
        public string name;
        public int health = 50;
        public int boredom = 50;
        public int hunger = 10;
        public bool canSwim;

        public Pet(string name)
        {
            this.name = name;
        }

        public void FeedPet()
        {
            
        }

        public void Display()
        {
            Console.WriteLine(sprite);
            Console.WriteLine(name);
            Console.WriteLine(health);
            Console.WriteLine(hunger);
            Console.WriteLine(boredom);
        }
    }
}