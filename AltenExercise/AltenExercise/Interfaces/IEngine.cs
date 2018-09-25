using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise.Interfaces
{
    interface IEngine
    {
        void Start();
        void Stop();

        double FuelLevel { get; }
        void AddFuel(double amount, FuelType fuelType);
    }
}
