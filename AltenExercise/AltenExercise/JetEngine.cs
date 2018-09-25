using AltenExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class JetEngine : Engine, IAirplaneEngine, IShipEngine
    {
        public JetEngine(double powerInHp, double torque) : base(powerInHp, torque)
        {
        }

        public double FuelLevel => throw new NotImplementedException();

        public void AddFuel(double amount, FuelType fuelType)
        {
            throw new NotImplementedException();
        }
    }
}
