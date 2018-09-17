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
            Car myCar = new Car("Volkswagen", "Polo");
            Console.WriteLine($"My Car is a {myCar.BrandName}");
        }
    }
}
