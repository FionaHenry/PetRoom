using System;

namespace PetRoom
{
    class Room
    {
        public double ambientTemperature = 18;
        public double currentTemperature;

        //A method to increase room temperature when player uses an item
        public void IncreaseRoomTemperature()
        {
            
        }

        //A method to decrease room temperature
        public void DecreaseRoomTemperature()
        {
            if(currentTemperature >= ambientTemperature)
            {
                currentTemperature--;
            }
        }
    }
}