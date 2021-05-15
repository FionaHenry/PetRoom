using System;

namespace PetTrySimulation
{
    class Room : RealTimeComponent
    {
        public double ambientTemperature = 18;
        public double currentTemperature = 24;


        //A method to increase room temperature when player uses an item
        public void IncreaseRoomTemperature()
        {
            currentTemperature += 5;
        }

        public void Initialise()
        {
            
        }

        //A method to change room temperature over time
        public void Update()
        {
            currentTemperature -= 0.1;
        }
    }
}