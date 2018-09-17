using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var keroPlane = new Airplane(FuelType.Kerosine);
            var electroPlane = new Airplane(FuelType.Electricity);

            var petrolCar = new Car(FuelType.Petrol);
            var dieselCar = new Car(FuelType.Diesel);
            var electroCar = new Car(FuelType.Electricity);

            var dieselBoat = new Ship(FuelType.Diesel);
            var keroBoat = new Ship(FuelType.Kerosine);
            var electroBoat = new Ship(FuelType.Electricity);

            var bike = new Bicycle( );

        }
    }
}

