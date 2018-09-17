using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    enum FuelType
    {
        Kerosine,
        Petrol,
        Diesel,
        Electricity
    }


    enum EngineStatus {
        Running, 
        Starting, 
        TurnedOff, 
        Dead,
        InTheShop
    }

    abstract public class Engine
    {
        private double m_fuelLevel = 0;
        private EngineStatus m_status = EngineStatus.TurnedOff;
        private FuelType m_fuel;

        internal FuelType Fuel { get => m_fuel; set => m_fuel = value; }
        internal EngineStatus Status { get => m_status; set => m_status = value; }

        public void Accelerate()
        {
        }

        public void Decelerate()
        {
        }

        public void Start()
        {
            Status = EngineStatus.Running;
        }

        public void Stop()
        {
            Status = EngineStatus.TurnedOff;
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
