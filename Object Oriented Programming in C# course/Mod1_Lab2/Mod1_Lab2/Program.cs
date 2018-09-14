using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2008);

            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars on inventory right now.");


        }
    }

    public class Car
    {
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        public Car()
        {
            instances++;
        }
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        private static int instances = 0;

        public static int CountCars()
        {
            return instances;
        }

        
    }
}
