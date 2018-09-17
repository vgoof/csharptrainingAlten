using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenVehicleExercise
{
    class CarFactory
    {
           

        public Car BuildVWPolo() {
            Car car = new Car("Volkswagen", "Polo", "diesel", 150, 500);
            return car;
        }

        public Car BuildVWUp()
        {
            Car car = new Car("Volkswagen", "Up!", "petrol", 50, 100);
            return car;
        }

        public Car BuildPeugeot308()
        {
            Car car = new Car("Peugeot", "308", "petrol", 180, 550);
            return car;
        }

        public Car BuildHondaCivic()
        {
            Car car = new Car("Honda", "Civic", "Hybrid", 200, 600);
            return car;
        }

        public Car BuildLexusCT200h()
        {
            Car car = new Car("Lexus", "CT200h");
            return car;
        }


    }
}
