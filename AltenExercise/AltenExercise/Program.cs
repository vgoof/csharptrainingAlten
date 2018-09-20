using System;

namespace AltenExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car vw = new CarBuilder()
                .CreateCarWithBrandName("Volkswagen")
                .WithModelName("Up!")
                .InstallEngine(new Engine(59, 95, EngineType.Petrol))
                .Build();

            Car peugeot = new CarBuilder()
                .CreateCarWithBrandName("Peugeot")
                .WithModelName("308")
                .InstallEngine(new Engine(128, 225, EngineType.Petrol))
                .Build();

            Car ford = new CarBuilder()
                .CreateCarWithBrandName("Ford")
                .WithModelName("Focus")
                .InstallEngine(new Engine(123, 201, EngineType.Diesel))
                .Build();

            Car honda = new CarBuilder()
                .CreateCarWithBrandName("Honda")
                .WithModelName("Civic")
                .InstallEngine(new Engine(90, 130, EngineType.Hybrid))
                .Build();

            Car lexus = new CarBuilder()
                .CreateCarWithBrandName("Lexus")
                .WithModelName("CT200h")
                .InstallEngine(new Engine(125, 210, EngineType.Hybrid))
                .Build();



        }
    }
}
