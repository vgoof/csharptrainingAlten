﻿using AltenExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class HybridEngine : Engine, ICarEngine
    {
        public HybridEngine(double powerInHp, double torque) : base(powerInHp, torque)
        {
        }

        public double FuelLevel => throw new NotImplementedException();

        public void AddFuel(double amount, FuelType fuelType)
        {
            throw new NotImplementedException();
        }
    }
}