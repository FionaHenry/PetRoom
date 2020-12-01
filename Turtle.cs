using System;

namespace PetRoom
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