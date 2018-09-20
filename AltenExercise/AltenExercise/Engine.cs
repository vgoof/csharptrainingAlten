using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Engine
    {
        public double PowerInHp { get; }
        public double Torque { get; }
        public EngineStatus EngineStatus { get; } = EngineStatus.TurnedOff;
        public EngineType EngineType { get; }

        public Engine(double powerInHp, double torque, EngineType engineType)
        {
            PowerInHp = powerInHp;
            Torque = torque;
            EngineType = engineType;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
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
        InTheShop
    }
}
