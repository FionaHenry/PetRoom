using System;

namespace PetTrySimulation
{
    class Cat : Pet
    {
        public Cat(string name)
            :base(name)
        {
            sprite = "Cat";
            canSwim = false;
        }
    }
}