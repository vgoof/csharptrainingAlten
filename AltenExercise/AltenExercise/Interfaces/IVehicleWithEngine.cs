using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    interface IVehicleWithEngine : IVehicle
    {
        void StartEngine();
        void StopEngine();
        EngineStatus EngineStatus { get; }
        FuelType FuelType { get; }
    }
}
