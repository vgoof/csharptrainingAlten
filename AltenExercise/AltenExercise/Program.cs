using System;

namespace AltenExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car vw = (Car)VehicleFactory.CreateVehicle(VehicleType.VolksWagenUp);

            Car peugeot = (Car)VehicleFactory.CreateVehicle(VehicleType.Peugeot308);

            Car ford = (Car)VehicleFactory.CreateVehicle(VehicleType.FordFocus);

            Car honda = (Car)VehicleFactory.CreateVehicle(VehicleType.FordFocus);

            Car lexus = (Car)VehicleFactory.CreateVehicle(VehicleType.LexusCT200h);





        }
    }
}
