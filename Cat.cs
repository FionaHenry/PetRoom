using System;

namespace PetRoom
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