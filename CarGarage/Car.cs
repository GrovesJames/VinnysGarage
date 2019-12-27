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
    }

}
