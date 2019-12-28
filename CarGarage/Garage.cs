using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    class Garage
    {
        public List<Car> Cars = new List<Car>();

        public void AddToGarage(Car Car)
        {
            Console.WriteLine("\nYou've added a new car to the garage!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
            Cars.Add(Car);
        }
        public void ShowCars()
        {
            Console.Clear();
            Console.WriteLine("Loading info on cars checked into the garage..");
            foreach (Car car in Cars)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\nCar Year: " + car.Year);
                Console.WriteLine("\nCar Make: " + car.Make);
                Console.WriteLine("\nCar Model: " + car.Model);
                Console.WriteLine("\nCar MPG: " + car.Mileage + "\n");
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void ShowCarsStats()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| Make     | Model    | Year    | Mileage    | Gas    | Performance |");
            Console.WriteLine("--------------------------------------------------------------\n");
            foreach (Car Car in Cars)
            {
                Console.WriteLine("--------------------------------------------------------------\n");
                Console.WriteLine("| " + Car.Make + "     | " + Car.Model + "     | " + Car.Year + "      | " + Car.Mileage + "     | " + Car.Gas + "      | " + Car.Performance + "    |\n");
                Console.WriteLine("--------------------------------------------------------------");
            }
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void DriveAllCars()
        {
            foreach (Car Car in Cars)
            {
                Car.Gas--;
            }
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void MaintainCars()
        {
            foreach (Car Car in Cars)
            {
                Car.Performance++;
            }
            Console.WriteLine("\nYou've performed maintenance on all cars in the garage!\n");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
        public Car ChooseCar()
        {
            int CarNum = 1;

            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            Console.WriteLine("\n Select a Car:\n");

            foreach (Car Car in Cars)
            {
                Console.WriteLine(CarNum + ". " + Car.Make + " " + Car.Model + "\n");
                CarNum++;
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");

            int CarChoice = Convert.ToInt32(Console.ReadLine());
            Car chosenCar = Cars[CarChoice - 1];
            return chosenCar;
        }
    }
}