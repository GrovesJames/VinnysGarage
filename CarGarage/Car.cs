using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int Gas { get; set; }
        public int Performance { get; set; }

        public Car()
        {
            Gas = 5;
            Performance = 5;
        }

        public void AddCar(string make, string model, int year, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public void InfoCar()
        {
            Console.WriteLine("\nYour car is a "+ Year + " " +  Make + " " + Model + "!");
            Console.WriteLine("\nIt gets " + Mileage + " miles to the gallon!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void StatsCar()
        {
            Console.WriteLine("\nYour car status levels are:");
            Console.WriteLine("Gas: " + Gas);
            Console.WriteLine("Performance: " + Performance);
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void TestDrive()
        {
            Gas--;
            Console.WriteLine("\nM: 'Lets get rolling!!'");
            Console.WriteLine("VROOOOOOOOOOOOM!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
        public void Maintenance()
        {
            Performance++;
            Console.WriteLine("\nM: Alright lets take a look..\n");
            Console.WriteLine("The mechanic improved the performance of your vehicle!");
            Console.WriteLine("\nPress enter to continue..");
            Console.ReadLine();
        }
    }
}