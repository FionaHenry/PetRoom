using System;

namespace PetTrySimulation
{
    class Fish : Pet
    {
        public Fish(string name)
            :base(name)
        {
            sprite = "Fish";
            canSwim = true;
        }
    }
}