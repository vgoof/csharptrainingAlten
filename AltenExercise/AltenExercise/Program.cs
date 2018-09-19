using System;

namespace AltenExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            CarBuilder cb = new CarBuilder();

            Car vw = cb.CreateCarWithBrandName("Volkswagen")
                .WithModelName("Up!")
                .InstallEngine(new Engine(120, 200))
                .Build();

        }
    }
}
