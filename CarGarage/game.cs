using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    class Game
    {
        public bool Exit = false;
        public string Make { get; set; }
        public string Model { get; set; }

        public Game()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nWelcome to Vinny's Car Garage!!\n");
            Console.WriteLine("\nStart a new game by pressing enter..\n");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nVinny: 'AAAAAaaaayyyy!! Welcome in! Let's check in your car!'\n");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("\nVin: 'What's the make of your car, buddy?'");
            string make = Console.ReadLine();

            Console.WriteLine("\nV: 'Allrrriigghttt, now what's the model of your car?'");
            string model = Console.ReadLine();

            Console.WriteLine("\nV: 'What about the year your car was made?'");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nV: 'Okay FINALLY.. the last one. How many miles does your car get per gallon of gas?'");
            int mileage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nV: 'I'll get you set up with my mechanic right now..'");
            Console.ReadLine();

            Car car = new Car();
            car.AddCar(make, model, year, mileage);
        }

        public void Enter()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\nMechanic: 'Alright buddy, listen up. I got a few options for ya:'\n\n");
            Console.WriteLine(" 1. Get car info\n");
            Console.WriteLine(" 2. Get car stats\n");
            Console.WriteLine(" 3. Take a car out for a test drive\n");
            Console.WriteLine(" 4. Perform maintenance on a car\n");

            Console.WriteLine("\n 4. Check in another car\n");
            Console.WriteLine(" 5. Check in another car\n");
            Console.WriteLine(" 6. View the info of all cars in the garage\n");
            Console.WriteLine(" 7. View the stats of all cars in the garage\n");
            Console.WriteLine(" 8. Perform maintenance on all cars in the garage\n");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
        }
    }
}