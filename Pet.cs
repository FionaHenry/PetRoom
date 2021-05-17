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
            hunger-=5;
        }

        public void Play()
        {
            boredom-=5;
        }

        public void GiveMedicine()
        {
            health+=5;
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

            if (Display.room.currentTemperature == Display.room.ambientTemperature)
            {
                health -= 1;
            }
        }
    }
}