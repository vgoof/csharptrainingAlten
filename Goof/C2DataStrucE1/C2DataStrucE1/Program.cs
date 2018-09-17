using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2DataStrucE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Silverado";
            myCar.Color = "Blue";
            myCar.Accelerate();

         }
    }

    struct Car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate()
        {
            Console.WriteLine("Vroooooom");
        }
    }
}
