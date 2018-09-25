using AltenExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Ship : IVehicleWithEngine
    {
        public double CurrentSpeed => throw new NotImplementedException();

        public EngineStatus EngineStatus => throw new NotImplementedException();

        public FuelType FuelType => _engine?.FuelType ?? FuelType.Unknown;

        private IShipEngine _engine;

        public Ship(IShipEngine engine)
        {
            _engine = engine;
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
