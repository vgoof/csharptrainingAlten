using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    abstract class Engine
    {
        public double PowerInHp { get; }
        public double Torque { get; }
        public EngineStatus EngineStatus { get; private set; } = EngineStatus.TurnedOff;

        public Engine(double powerInHp, double torque)
        {
            PowerInHp = powerInHp;
            Torque = torque;
        }

        public void Start()
        {
            if(EngineStatus == EngineStatus.TurnedOff)
            {
                EngineStatus = EngineStatus.Running;
            }
            else
            {
                Console.WriteLine("Can't start engine.");
            }
        }

        public void Stop()
        {
            if(EngineStatus == EngineStatus.Running)
            {
                EngineStatus = EngineStatus.TurnedOff;
            }
            else
            {
                Console.WriteLine("Can't stop engine.");
            }
        }
    }

    public enum FuelType
    {
        Kerosine,
        Diesel,
        Petrol,
        Electricity
    }

    public enum EngineStatus
    {
        Running,
        Starting,
        TurnedOff,
        Dead,
        InTheShop,
        Missing
    }
}
