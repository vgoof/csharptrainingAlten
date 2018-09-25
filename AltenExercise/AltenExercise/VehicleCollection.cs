using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace AltenExercise
{
    class VehicleCollection: IEnumerable
    {

        private List<IVehicle> vehicles = new List<IVehicle>();

        public void Add(IVehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void Remove(IVehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }

        public IEnumerator GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        public IEnumerable<IVehicle> GetAllVehicles()
        {
            return vehicles.ToArray();
        }

        public IEnumerable<IVehicleWithEngine> GetAllVehiclesWithEngines()
        {
            //return vehicles.OfType<IVehicleWithEngine>();

            foreach(IVehicleWithEngine v in vehicles.Where(v => v is IVehicleWithEngine))
            {
                yield return v;
            }
                //
            //IEnumerable<IVehicleWithEngine> filteredVehicles = vehicles.Where(n => n as IVehicleWithEngine);

        }

        public IEnumerable<Airplane> GetAllAirplanes()
        {
            return vehicles.OfType<Airplane>();
        }

        public IEnumerable<Car> GetAllCars()
        {
            return vehicles.OfType<Car>();
        }

        public IEnumerable<Bicycle> GetAllBicycles()
        {
            return vehicles.OfType<Bicycle>();
        }

        public IEnumerable<Ship> GetAllShips()
        {
            return vehicles.OfType<Ship>();
        }

    }
}
