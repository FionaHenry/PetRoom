using System;

namespace PetTrySimulation
{
    class Room
    {
        public double ambientTemperature = 18;
        public double currentTemperature = 24;


        //A method to increase room temperature when player uses an item
        public void IncreaseRoomTemperature()
        {
            currentTemperature += 5;
        }

        //A method to change room temperature over time
        public void AdjustCurrentTemperature()
        {
            currentTemperature -= 0.1;
        }
    }
}