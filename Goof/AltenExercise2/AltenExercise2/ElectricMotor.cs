﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    class ElectricMotor : Engine
    {
        public ElectricMotor()
        {
            Fuel = FuelType.Electricity;
        }
    }
}
