using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltenExercise2
{
    public class VehicleWithEngine : Vehicle
    {
        private Engine m_engine;

        public Engine Engine { get => m_engine; private set => m_engine = value; }

        public void StartEngine()
        {
            m_engine.Start();
        }



    }
}
