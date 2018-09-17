﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenVehicleExercise
{
    enum EngineStatus {
        Running, 
        Starting,
        TurnedOff,
        Dead,
        InTheShop
    }


    class Engine
    {
        private double m_powerInHP;
        private double m_torque;
        private EngineStatus m_status;

        public Engine(double power, double torque)
        {
            m_powerInHP = power;
            m_torque = torque;
            m_status = EngineStatus.TurnedOff;
        }

        public double PowerInHP { get => m_powerInHP; }
        public double Torque { get => m_torque; }
        public EngineStatus GetStatus() {
            return m_status;
        }
        public void Start() {
            m_status = EngineStatus.Starting;
        }
        public void Stop() {
            m_status = EngineStatus.TurnedOff;
        }


    }
}
