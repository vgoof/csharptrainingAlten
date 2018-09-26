using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Bicycle : IVehicle
    {
        public double CurrentSpeed => throw new NotImplementedException();
        private List<Person> _passengers = new List<Person>();


        public void EnterVehicle(Person p)
        {
            _passengers.Add(p);
            p.GetInVehicle(this);
        }

        public void ExitVehicle(Person p)
        {
            _passengers.Remove(p);
            p.GetOutOfVehicle();
        }

        public Person[] GetPassengers()
        {
            return _passengers.ToArray();
        }
    }
}
