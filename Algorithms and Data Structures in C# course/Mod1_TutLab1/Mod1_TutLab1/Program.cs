using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_TutLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mondeo";
            car.Year = 2002;
            
            car.Color = "Black";

            Console.WriteLine($"My car is a {car.Make} {car.Model} from {car.Year} that is {car.Color} in color.");
            car.Accelerate();
        }

        struct Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public void Accelerate()
            {
                Console.WriteLine("Vroom");
            }
        }
    }
}
