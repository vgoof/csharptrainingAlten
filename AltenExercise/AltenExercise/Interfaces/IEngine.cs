using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise.Interfaces
{
    interface IEngine
    {
        FuelType FuelType { get;  }
        void Start();
        void Stop();

        double FuelLevel { get; }
        void AddFuel(double amount, FuelType fuelType);
    }
}
