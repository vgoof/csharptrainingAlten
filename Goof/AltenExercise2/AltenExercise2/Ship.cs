using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    class Ship : VehicleWithEngine
    {
        public Ship(FuelType fuel)
        {
            if (fuel == FuelType.Diesel)
            {
                Engine = new DieselEngine();
            }
            else if (fuel == FuelType.Kerosine)
            {
                Engine = new JetEngine();
                // I don't thinks ships run on kerosine:)
            }
            else if (fuel == FuelType.Electricity)
            {
                Engine = new ElectricMotor();
            }
            else
            {
                throw new System.ArgumentException("Fueltype must by kerosine, diesel, or electricity");
            }
        }
    }
}
