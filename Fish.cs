using System;

namespace PetRoom
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