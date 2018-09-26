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


            VehicleCollection v = new VehicleCollection
            {
                vw,
                peugeot,
                ford,
                honda,
                lexus,
                new Bicycle()
            };

            Console.WriteLine(string.Join(", ", v.GetAllOfType<Bicycle>()));

            Person p = new Person("John Doe");
            vw.EnterVehicle(p, true);
            vw.StartEngine();
            vw.StopEngine();
            vw.ExitVehicle(p);
            vw.StartEngine();
            vw.EnterVehicle(p);
            p.AccelerateVehicle();
        
        }
    }
}
