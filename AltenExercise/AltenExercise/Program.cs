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



            honda.StartEngine();

            Console.WriteLine($"Honda engine status : {honda.EngineStatus}");

            Console.WriteLine($"Lexus engine status : {lexus.EngineStatus}");

            Car car = new Car.CarBuilder().Build();
            Console.WriteLine(car.EngineStatus);
            car.StartEngine();


            VehicleCollection v = new VehicleCollection();

            v.Add(vw);
            v.Add(peugeot);
            v.Add(ford);
            v.Add(honda);
            v.Add(lexus);

            v.Add(new Bicycle());
            var vehiclesWithEngines = v.GetAllVehiclesWithEngines();

            foreach(var vwe in vehiclesWithEngines)
            {
                Console.WriteLine(vwe);
            }

            Console.WriteLine(String.Join(", ", vehiclesWithEngines));
            Console.WriteLine(String.Join(", ", v.GetAllVehicles()));
        }
    }
}
