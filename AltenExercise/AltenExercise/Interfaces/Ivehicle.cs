using System;
using System.Collections.Generic;
using System.Text;

namespace AltenExercise
{
    interface IVehicle
    {
        double CurrentSpeed { get; }
        Person[] GetPassengers();
        void EnterVehicle(Person p);
        void ExitVehicle(Person p);
    }
}
