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
        public Car chosenCar = new Car();
        public Garage Garage = new Garage();

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

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\nVinny: 'AAAAAaaaayyyy!! Welcome in! Let's check in your car!'\n");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("\nVin: 'What's the make of your car, buddy?'");
            string make = Console.ReadLine();

            Console.WriteLine("\nV: 'Allrrriigghttt, now what's the model of your car?'");
            string model = Console.ReadLine();

            Console.WriteLine("\nV: 'What about the year your car was made?'");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nV: 'Okay FINALLY.. the last one. How many miles does your car get per gallon of gas?'");
            int mileage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nV: 'I'll get you set up with my mechanic right now..'");

            Car car = new Car();
            car.AddCar(make, model, year, mileage);
            Garage.AddToGarage(car);
        }

        public void Enter()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\nMechanic: 'Alright buddy, listen up. I got a few options for ya:'\n\n");
            Console.WriteLine(" 1. Get car info");
            Console.WriteLine(" 2. Get car stats");
            Console.WriteLine(" 3. Take a car out for a test drive");
            Console.WriteLine(" 4. Perform maintenance on a car");

            Console.WriteLine("\n 5. Check in another car");
            Console.WriteLine(" 6. View the info of all cars in the garage");
            Console.WriteLine(" 7. View the stats of all cars in the garage");
            Console.WriteLine(" 8. Perform maintenance on all cars in the garage\n\n");

            Console.WriteLine(" 0. Exit Vinny's garage\n");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            if (menuChoice == 1)
            {
                chosenCar = Garage.ChooseCar();
                chosenCar.InfoCar();
            }
            else if (menuChoice == 2)
            {
                chosenCar = Garage.ChooseCar();
                chosenCar.StatsCar();
            }
            else if (menuChoice == 3)
            {
                chosenCar = Garage.ChooseCar();
                chosenCar.TestDrive();
            }
            else if (menuChoice == 4)
            {
                chosenCar = Garage.ChooseCar();
                chosenCar.Maintenance();
            }
            else if (menuChoice == 5)
            {
                Console.Clear();
                Console.WriteLine("\nM: 'What's the make of your new vehicle?'");
                string make = Console.ReadLine();

                Console.WriteLine("\nM: 'And the model?'");
                string model = Console.ReadLine();

                Console.WriteLine("\nM: 'What about the year it was made?'");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nM: 'Lastly, the miles you get per gallon?'");
                int mileage = Convert.ToInt32(Console.ReadLine());

                Car car = new Car();
                car.AddCar(make, model, year, mileage);
                Garage.AddToGarage(car);

            }
            else if (menuChoice == 6)
            {
                Garage.ShowCars();
            }
            else if (menuChoice == 7)
            {
                Garage.ShowCarsStats();
            }
            else if (menuChoice == 8)
            {
                Garage.MaintainCars();
            }
            else if (menuChoice == 0)
            {
                Exit = true;
            }
        }
    }
}