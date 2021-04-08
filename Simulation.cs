using System;
using System.Threading;
using System.Collections.Generic;

namespace PetTrySimulation
{

    public enum AppState
    {
        Running,
        Store,
        Inventory,
        Exiting
    }

    class Simulation : RealTimeComponent
    {
        Counter counter = new Counter(1000);
        Display display = new Display();
        Store store = new Store();
        static List<Pet> pets = new List<Pet>();
        AppState appState = AppState.Running;

        public Simulation()
        {
            
        }

        public void Run()
        {
            Inventory playerInventory = new Inventory();
            Initialise();
            
            do
            {
                
                CheckKeyInput();

                switch (appState)
                {
                    case AppState.Running:
                    Running();
                    Console.WriteLine("running");
                        break;
                    case AppState.Store:
                    Store();
                    Console.WriteLine("store");
                        break;
                    case AppState.Inventory:
                    Inventory();
                    Console.WriteLine("Inventory");
                        break;
                    default:
                        break;
                }
                
                Update();
                foreach(Pet pet in pets)
                {
                    pet.Update();
                }

                Thread.Sleep(1000);
            } while (appState != AppState.Exiting);
        }

        public void Initialise()
        {
            counter.Initialise();
            Pet cat = new Cat("Fred");
            pets.Add(cat);
            display.DisplayPets(pets);
            display.DisplayMenu();
        }

        public void Running()
        {
            display.DisplayPets(pets);
            display.DisplayMenu();
        }

        public void Store()
        {
            
        }

        public void Inventory()
        {
            
        }

        public void CheckKeyInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey keyPressed = Console.ReadKey(true).Key;

                if (keyPressed == ConsoleKey.Escape)
                {
                    appState = AppState.Exiting;
                }

                if (keyPressed == ConsoleKey.NumPad1 || keyPressed == ConsoleKey.D1)
                {
                    appState = AppState.Store;
                }

                if (keyPressed == ConsoleKey.NumPad2 || keyPressed == ConsoleKey.D2)
                {
                    appState = AppState.Inventory;
                }

                if (keyPressed == ConsoleKey.NumPad3 || keyPressed == ConsoleKey.D3)
                {
                    appState = AppState.Running;
                }
            }
        }

        public void Update()
        {
            counter.Update();
        }
    }
}
