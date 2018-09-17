using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    class Airplane : VehicleWithEngine
    {
        public Airplane(FuelType fuel) {
            if (fuel == FuelType.Kerosine)
            {
                Engine = new JetEngine();
            }
            else if (fuel == FuelType.Electricity)
            {
                    Engine = new ElectricMotor();
            }
            else
            {                     
               throw new System.ArgumentException("Fueltype must by kerosine, or electricity");                
            }
        }
    }
}
