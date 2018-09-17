using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AltenVehicleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine myEngine = new Engine(150, 500);
            Car myCar = new Car("Volkswagen", "Polo", myEngine);
            Console.WriteLine($"My Car is a {myCar.BrandName} {myCar.ModelName}");
        }
    }
}
