using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Engine
    {
        public double PowerInHp { get; }
        public double Torque { get; }
        public EngineStatus EngineStatus { get; private set; } = EngineStatus.TurnedOff;
        public EngineType EngineType { get; }

        public Engine(double powerInHp, double torque, EngineType engineType)
        {
            PowerInHp = powerInHp;
            Torque = torque;
            EngineType = engineType;
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

    public enum EngineType
    {
        Petrol,
        Diesel,
        Electric,
        Hybrid,
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
