using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    class Car : VehicleWithEngine
    {
        public Car(FuelType fuel) {
            if (fuel == FuelType.Diesel)
            {
                Engine = new DieselEngine();
            }
            else if (fuel == FuelType.Petrol)
            {
                Engine = new PetrolEngine();
            }
            else if (fuel == FuelType.Electricity)
            {
                Engine = new ElectricMotor();
            }
            else {
                throw new System.ArgumentException("Fueltype must be petrol, diesel, or electricity");
            }
        }
    }
}
