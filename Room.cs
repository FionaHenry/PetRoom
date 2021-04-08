using System;

namespace PetTrySimulation
{
    class Room
    {
        public double ambientTemperature = 18;
        public double currentTemperature;

        //A method to increase room temperature when player uses an item
        public void IncreaseRoomTemperature()
        {
            
        }

        //A method to change room temperature over time
        public void AdjustCurrentTemperature()
        {
            if(currentTemperature >= ambientTemperature)
            {
                currentTemperature = currentTemperature - 0.01;
            }
            else
            {
                currentTemperature = currentTemperature = 0.01;
            }
        }
    }
}