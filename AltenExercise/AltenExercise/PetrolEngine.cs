using AltenExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class PetrolEngine : Engine, ICarEngine
    {
        public PetrolEngine(double powerInHp, double torque) : base(powerInHp, torque)
        {
        }

        public double FuelLevel => throw new NotImplementedException();

        public FuelType FuelType => FuelType.Petrol;

        public void AddFuel(double amount, FuelType fuelType)
        {
            throw new NotImplementedException();
        }
    }
}
