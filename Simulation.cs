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
        public static Store store = new Store();
        public static Inventory playerInventory = new Inventory();
        static List<Pet> pets = new List<Pet>();
        AppState appState = AppState.Running;

        public Simulation()
        {
            
        }

        public void Run()
        {
            Initialise();
            
            do
            {
                
                CheckKeyInput();

                switch (appState)
                {
                    case AppState.Running:
                    Running();
                        break;
                    case AppState.Store:
                    Store();
                        break;
                    case AppState.Inventory:
                    Inventory();
                        break;
                    default:
                        break;
                }
                
                Update();
                foreach(Pet pet in pets)
                {
                    pet.Update();
                }
                
                display.DisplayMenu();


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
            store.InitialiseStore();
        }

        public void Running()
        {
            display.DisplayPets(pets);
            Console.WriteLine($"You have {playerInventory.coins} coins available to spend");
        }

        public void Store()
        {
            Console.WriteLine("Food Store");
            store.DisplayFoodStore();
            Console.WriteLine("Toy Store");
            store.DisplayToyStore();
            Console.WriteLine("Medicine Store");
            store.DisplayMedicineStore();
        }

        public void Inventory()
        {
            playerInventory.DisplayInventory();
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
                
                if (keyPressed == ConsoleKey.NumPad4 || keyPressed == ConsoleKey.D4)
                {
                    foreach (Pet pet in pets)
                    {
                        pet.FeedPet();
                    }
                }

                if (keyPressed == ConsoleKey.NumPad5 || keyPressed == ConsoleKey.D5)
                {
                    foreach (Pet pet in pets)
                    {
                        pet.Play();
                    }
                }

                if (keyPressed == ConsoleKey.NumPad6 || keyPressed == ConsoleKey.D6)
                {
                    foreach (Pet pet in pets)
                    {
                        pet.GiveMedicine();
                    }
                }

                if (keyPressed == ConsoleKey.A)
                {
                    store.PurchaseCatFood();
                }

                if (keyPressed == ConsoleKey.B)
                {
                    store.PurchaseLuxuryFood();
                }

                if (keyPressed == ConsoleKey.C)
                {
                    store.PurchaseCatToy();
                }

                if (keyPressed == ConsoleKey.D)
                {
                    store.PurchaseLuxuryCatToy();
                }

                if (keyPressed == ConsoleKey.E)
                {
                    store.PurchaseCatMedicine();
                }

                if (keyPressed == ConsoleKey.T)
                {
                    Display.room.IncreaseRoomTemperature();
                }
            }
        }

        public void Update()
        {
            counter.Update();
            Display.room.Update();
            playerInventory.Update();
        }
    }
}
