using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    class Person
    {

        public string Name { get; private set; }

        public void OnEngineStarted(object source, EventArgs e)
        {
            Console.WriteLine($"Wow, {Name} knows the engine started!");
        }

        public void OnEngineStopped(object source, EventArgs e)
        {
            Console.WriteLine($"Wow, {Name} knows the engine turned off!");
        }

        private IVehicle _onVehicle;

        public Person(string name)
        {
            Name = name;
        }

        public void GetInVehicle(IVehicle v)
        {
            _onVehicle = v;
        }

        public void GetOutOfVehicle()
        {
            _onVehicle = null;
        }

        public void AccelerateVehicle()
        {
            
        }
    }
}
