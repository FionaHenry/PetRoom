using System;

namespace PetTrySimulation
{
    class Pet : RealTimeComponent
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

        public void Initialise()
        {
            
        }

        public void Update()
        {
            if(hunger>25)
            {
            health -= 1;
            }
            boredom += 1;
            hunger += 1;
        }
    }
}