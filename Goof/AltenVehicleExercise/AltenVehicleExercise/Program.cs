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
            CarFactory factory = new CarFactory();

            Car myCar = factory.BuildVWPolo();
            Car Car1 = factory.BuildVWUp();
            Car Car2 = factory.BuildPeugeot308();
            Car Car3 = factory.BuildHondaCivic();
            Car Car4 = factory.BuildLexusCT200h();

            Console.WriteLine($"My Car is a {myCar.BrandName} {myCar.ModelName}");

            Car3.GetEngine.Start();
            Car4.GetEngine.Start();

            Console.WriteLine($"My car engine status is { myCar.GetEngine.GetStatus() }");

        }
    }
}
