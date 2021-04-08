using System;

namespace PetTrySimulation
{
    class Turtle : Pet
    {
        public Turtle(string name)
            :base(name)
        {
            sprite = "Turtle";
            canSwim = true;
        }
    }
}