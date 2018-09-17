using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    //public class VehicleCollection<T>: IEnumerable<T> where T : Vehicle
    public class VehicleCollection<T> where T : Vehicle
    {
        private List<T> m_vehicles = new List<T>();

        public void FillList(params T[] items)
        {
            foreach (var vehicle in items)
                m_vehicles.Add(vehicle);
        }
        public void Add(T newVehicle) {
            m_vehicles.Add(newVehicle);
        }

        public List<T> Get<T>()
        {
            return m_vehicles.OfType<T>().ToList();
        }

        //IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //{
        //    foreach (var vehicle in m_vehicles)
        //    {
        //        yield return vehicle;
        //    }
        //}
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}




    }
}
