using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    //public class VehicleCollection<T>: IEnumerable<T> where T : Vehicle
   // public class VehicleCollection<T> where T : Vehicle
   // do I need T and where here? or would it be fine to just say Vehicle?
   // Answer: just use Vehicle:), adding T here is maybe a bit shorter
   public class VehicleCollection<Vehicle>
    {
        private List<Vehicle> m_vehicles = new List<Vehicle>();
                
        public void Add(Vehicle newVehicle) {
            m_vehicles.Add(newVehicle);
        }

        public List<T> Get<T>()
        {
            return m_vehicles.OfType<T>().ToList();
        }



    }
}
