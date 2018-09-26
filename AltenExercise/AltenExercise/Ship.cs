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
        private List<Person> _passengers = new List<Person>();

        public Ship(IShipEngine engine)
        {
            _engine = engine;
        }

        public void EnterVehicle(Person p)
        {
            _passengers.Add(p);
            p.GetInVehicle(this);
        }

        public void ExitVehicle(Person p)
        {
            _passengers.Remove(p);
            p.GetOutOfVehicle();
        }

        public Person[] GetPassengers()
        {
            return _passengers.ToArray();
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
