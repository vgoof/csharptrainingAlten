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

        public Engine(double powerInHp, double torque)
        {
            PowerInHp = powerInHp;
            Torque = torque;
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

    public enum EngineStatus
    {
        Running,
        Starting,
        TurnedOff,
        Dead,
        InTheShop
    }
}
