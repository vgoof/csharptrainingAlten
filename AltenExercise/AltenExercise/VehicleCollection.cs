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

        public IEnumerable<T> GetAllOfType<T>()
        {
            return vehicles.OfType<T>();
            //foreach (T v in vehicles.Where(v => v is T))
            //    yield return v;
        }
    }
}
