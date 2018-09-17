using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    enum FuelType {
        Kerosine,
        Petrol,
        Diesel, 
        Electricity
    }


    abstract class Engine
    {
        private double m_fuelLevel = 0;
        FuelType m_fuel;

        internal FuelType Fuel { get => m_fuel; set => m_fuel = value; }

        public void Accelerate()
        {
        }

        public void Decelerate()
        {
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public virtual double GetFuelLevel()
        {
            return m_fuelLevel;
        }

        public virtual void AddFuel(double amount, FuelType fueltype)
        {
            if (fueltype == Fuel)
            {
                m_fuelLevel += amount;
            }

        }


    }
}
